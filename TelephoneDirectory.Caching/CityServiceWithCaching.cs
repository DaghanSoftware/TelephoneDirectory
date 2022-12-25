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
using TelephoneDirectory.Service.Exceptions;

namespace TelephoneDirectory.Caching
{
    public class CityServiceWithCaching : ICityService
    {
        private const string CacheCityKey = "cityCache";
        private readonly IMapper _mapper;
        private readonly IMemoryCache _memoryCache;
        private readonly ICityRepository _cityRepository;
        private readonly IUnitOfWork _unitofwork;

        public CityServiceWithCaching(IMapper mapper, IMemoryCache memoryCache, ICityRepository cityRepository, IUnitOfWork unitofwork)
        {
            _mapper = mapper;
            _memoryCache = memoryCache;
            _cityRepository = cityRepository;
            _unitofwork = unitofwork;

            if (!_memoryCache.TryGetValue(CacheCityKey, out _))
            {
                _memoryCache.Set(CacheCityKey, _cityRepository.GetAll().ToList());
            }
        }

        public async Task<CustomResponseDto<CityDto>> AddAsync(CityDto dto)
        {
            var newEntity = _mapper.Map<City>(dto);
            await _cityRepository.AddAsync(newEntity);
            await _unitofwork.CommitAsync();
            var newDto = _mapper.Map<CityDto>(newEntity);
            await CacheAllCityAsync();
            return CustomResponseDto<CityDto>.Success(StatusCodes.Status200OK, newDto);
        }

        public async Task<CustomResponseDto<IEnumerable<CityDto>>> AddRangeAsync(IEnumerable<CityDto> dtos)
        {
            var newEntity = _mapper.Map<IEnumerable<City>>(dtos);
            await _cityRepository.AddRangeAsync(newEntity);
            await _unitofwork.CommitAsync();
            var newDto = _mapper.Map<List<CityDto>>(newEntity);
            await CacheAllCityAsync();
            return CustomResponseDto<IEnumerable<CityDto>>.Success(StatusCodes.Status200OK, newDto);
        }

        public Task<CustomResponseDto<bool>> AnyAsync(Expression<Func<City, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<CustomResponseDto<IEnumerable<CityDto>>> GetAllAsync()
        {
            var newEntity = _mapper.Map<List<CityDto>>(_memoryCache.Get<IEnumerable<City>>(CacheCityKey));
            return Task.FromResult(CustomResponseDto<IEnumerable<CityDto>>.Success(StatusCodes.Status200OK, newEntity));
        }

        public Task<CustomResponseDto<CityDto>> GetByIdAsync(int id)
        {
            var city = _mapper.Map<CityDto>(_memoryCache.Get<List<City>>(CacheCityKey).FirstOrDefault(x => x.Id == id));
            if (city == null)
            {
                throw new NotFoundException($"{typeof(City).Name} ({id}) not found");
            }
            else
            {
                return Task.FromResult(CustomResponseDto<CityDto>.Success(StatusCodes.Status200OK, city));
            }
        }

        public async Task<CustomResponseDto<NoContentDto>> RemoveAsync(int id)
        {
            var entity = await _cityRepository.GetByIdAsync(id);
            _cityRepository.Remove(entity);
            await _unitofwork.CommitAsync();
            await CacheAllCityAsync();
            return CustomResponseDto<NoContentDto>.Success(StatusCodes.Status204NoContent);
        }

        public async Task<CustomResponseDto<NoContentDto>> RemoveRangeAsync(IEnumerable<int> ids)
        {
            var entites = await _cityRepository.Where(x => ids.Contains(x.Id)).ToListAsync();
            _cityRepository.RemoveRange(entites);
            await _unitofwork.CommitAsync();
            await CacheAllCityAsync();
            return CustomResponseDto<NoContentDto>.Success(StatusCodes.Status204NoContent);
        }

        public async Task<CustomResponseDto<NoContentDto>> UpdateAsync(CityDto dto)
        {
            var newEntity = _mapper.Map<City>(dto);
            _cityRepository.Update(newEntity);
            await _unitofwork.CommitAsync();
            await CacheAllCityAsync();
            return CustomResponseDto<NoContentDto>.Success(StatusCodes.Status204NoContent);
        }

        public Task<CustomResponseDto<IEnumerable<CityDto>>> Where(Expression<Func<City, bool>> expression)
        {
            var city = _mapper.Map<List<CityDto>>(_memoryCache.Get<List<City>>(CacheCityKey).Where(expression.Compile()).AsEnumerable());
            return Task.FromResult(CustomResponseDto<IEnumerable<CityDto>>.Success(StatusCodes.Status200OK, city));
        }

        public async Task CacheAllCityAsync()
        {
            _memoryCache.Set(CacheCityKey, await _cityRepository.GetAll().ToListAsync());
        }
    }
}
