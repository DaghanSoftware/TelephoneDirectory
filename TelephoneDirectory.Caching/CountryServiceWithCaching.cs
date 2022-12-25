using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectory.Core.Models.DTOs;
using TelephoneDirectory.Core.Models.Entities;
using TelephoneDirectory.Core.Repositories;
using TelephoneDirectory.Core.Services;
using TelephoneDirectory.Core.UnitOfWorks;
using TelephoneDirectory.Repository.Repositories;
using TelephoneDirectory.Repository.UnitOfWorks;
using TelephoneDirectory.Service.Exceptions;

namespace TelephoneDirectory.Caching
{
    
    public class CountryServiceWithCaching:ICountryService
    {
        private const string CacheCountryKey = "categoriesCache";
        private readonly IMapper _mapper;
        private readonly IMemoryCache _memoryCache;
        private readonly ICountryRepository _countryRepository;
        private readonly IUnitOfWork _unitofwork;

        public CountryServiceWithCaching(IMapper mapper, IMemoryCache memoryCache, ICountryRepository countryRepository, IUnitOfWork unitofwork)
        {
            _mapper = mapper;
            _memoryCache = memoryCache;
            _countryRepository = countryRepository;
            _unitofwork = unitofwork;
            if (!_memoryCache.TryGetValue(CacheCountryKey, out _))
            {
                var countryentities = _countryRepository.GetAll().ToList();
                var newDto = _mapper.Map<List<CountryDto>>(countryentities);
                _memoryCache.Set(CacheCountryKey, newDto);
            }
        }

        public async Task<CustomResponseDto<CountryDto>> AddAsync(CountryDto dto)
        {
            var newEntity = _mapper.Map<Country>(dto);
            await _countryRepository.AddAsync(newEntity);
            await _unitofwork.CommitAsync();
            var newDto = _mapper.Map<CountryDto>(newEntity);
            await CacheAllCountryAsync();
            return CustomResponseDto<CountryDto>.Success(StatusCodes.Status200OK, newDto);
        }

        public async Task<CustomResponseDto<IEnumerable<CountryDto>>> AddRangeAsync(IEnumerable<CountryDto> dtos)
        {
            var newEntity = _mapper.Map<IEnumerable<Country>>(dtos);
            await _countryRepository.AddRangeAsync(newEntity);
            await _unitofwork.CommitAsync();
            var newDto = _mapper.Map<List<CountryDto>>(newEntity);
            await CacheAllCountryAsync();
            return CustomResponseDto<IEnumerable<CountryDto>>.Success(StatusCodes.Status200OK, newDto);
        }

        public Task<CustomResponseDto<bool>> AnyAsync(Expression<Func<Country, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<CustomResponseDto<IEnumerable<CountryDto>>> GetAllAsync()
        {
            var newEntity = _memoryCache.Get<IEnumerable<CountryDto>>(CacheCountryKey);
            return Task.FromResult(CustomResponseDto<IEnumerable<CountryDto>>.Success(StatusCodes.Status200OK, newEntity));
        }

        public Task<CustomResponseDto<CountryDto>> GetByIdAsync(int id)
        {
            var country = _memoryCache.Get<List<CountryDto>>(CacheCountryKey).FirstOrDefault(x => x.Id == id);
            if (country == null)
            {
                throw new NotFoundException($"{typeof(Country).Name} ({id}) not found");
            }
            else
            {
                return Task.FromResult(CustomResponseDto<CountryDto>.Success(StatusCodes.Status200OK, country));
            }
        }

        public async Task<CustomResponseDto<NoContentDto>> RemoveAsync(int id)
        {
            var entity = await _countryRepository.GetByIdAsync(id);
            _countryRepository.Remove(entity);
            await _unitofwork.CommitAsync();
            await CacheAllCountryAsync();
            return CustomResponseDto<NoContentDto>.Success(StatusCodes.Status204NoContent);
        }

        public async Task<CustomResponseDto<NoContentDto>> RemoveRangeAsync(IEnumerable<int> ids)
        {
            var entites = await _countryRepository.Where(x => ids.Contains(x.Id)).ToListAsync();
            _countryRepository.RemoveRange(entites);
            await _unitofwork.CommitAsync();
            await CacheAllCountryAsync();
            return CustomResponseDto<NoContentDto>.Success(StatusCodes.Status204NoContent);
        }

        public async Task<CustomResponseDto<NoContentDto>> UpdateAsync(CountryDto dto)
        {
            var newEntity = _mapper.Map<Country>(dto);
            _countryRepository.Update(newEntity);
            await _unitofwork.CommitAsync();
            await CacheAllCountryAsync();
            return CustomResponseDto<NoContentDto>.Success(StatusCodes.Status204NoContent);
        }

        public Task<CustomResponseDto<IEnumerable<CountryDto>>> Where(Expression<Func<Country, bool>> expression)
        {
            var newDto = _mapper.Map<List<CountryDto>>(_memoryCache.Get<List<Country>>(CacheCountryKey).Where(expression.Compile()).AsEnumerable());
            return Task.FromResult(CustomResponseDto<IEnumerable<CountryDto>>.Success(StatusCodes.Status200OK, newDto));
        }
        public async Task CacheAllCountryAsync()
        {
            _memoryCache.Set(CacheCountryKey,  _mapper.Map<List<CountryDto>>(await _countryRepository.GetAll().ToListAsync()));
        }
    }
}
