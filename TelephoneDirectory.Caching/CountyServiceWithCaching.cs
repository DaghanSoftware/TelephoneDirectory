using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System.Linq.Expressions;
using TelephoneDirectory.Core.Models.DTOs;
using TelephoneDirectory.Core.Models.Entities;
using TelephoneDirectory.Core.Repositories;
using TelephoneDirectory.Core.Services;
using TelephoneDirectory.Core.UnitOfWorks;
using TelephoneDirectory.Service.Exceptions;

namespace TelephoneDirectory.Caching
{
    public class CountyServiceWithCaching : ICountyService
    {
        private const string CacheCountyKey = "countyCache";
        private readonly IMapper _mapper;
        private readonly IMemoryCache _memoryCache;
        private readonly ICountyRepository _countyRepository;
        private readonly IUnitOfWork _unitofwork;

        public CountyServiceWithCaching(IMapper mapper, IMemoryCache memoryCache, ICountyRepository countyRepository, IUnitOfWork unitofwork)
        {
            _mapper = mapper;
            _memoryCache = memoryCache;
            _countyRepository = countyRepository;
            _unitofwork = unitofwork;
            if (!_memoryCache.TryGetValue(CacheCountyKey, out _))
            {
                var deneme = _countyRepository.GetAll().ToList();
                _memoryCache.Set(CacheCountyKey, _countyRepository.GetAll().ToList());
            }
        }

        public async Task<CustomResponseDto<CountyDto>> AddAsync(CountyDto dto)
        {
            var newEntity = _mapper.Map<County>(dto);
            await _countyRepository.AddAsync(newEntity);
            await _unitofwork.CommitAsync();
            var newDto = _mapper.Map<CountyDto>(newEntity);
            await CacheAllCountyAsync();
            return CustomResponseDto<CountyDto>.Success(StatusCodes.Status200OK, newDto); ;
        }

        public async Task<CustomResponseDto<IEnumerable<CountyDto>>> AddRangeAsync(IEnumerable<CountyDto> dtos)
        {
            var newEntity = _mapper.Map<IEnumerable<County>>(dtos);
            await _countyRepository.AddRangeAsync(newEntity);
            await _unitofwork.CommitAsync();
            var newDto = _mapper.Map<List<CountyDto>>(newEntity);
            await CacheAllCountyAsync();
            return CustomResponseDto<IEnumerable<CountyDto>>.Success(StatusCodes.Status200OK, newDto);
        }

        public Task<CustomResponseDto<bool>> AnyAsync(Expression<Func<County, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<CustomResponseDto<IEnumerable<CountyDto>>> GetAllAsync()
        {
            var newEntity = _mapper.Map<List<CountyDto>>(_memoryCache.Get<IEnumerable<County>>(CacheCountyKey));
            return Task.FromResult(CustomResponseDto<IEnumerable<CountyDto>>.Success(StatusCodes.Status200OK, newEntity));
        }

        public Task<CustomResponseDto<CountyDto>> GetByIdAsync(int id)
        {
            var city = _mapper.Map<CountyDto>(_memoryCache.Get<List<County>>(CacheCountyKey).FirstOrDefault(x => x.Id == id));
            if (city == null)
            {
                throw new NotFoundException($"{typeof(City).Name} ({id}) not found");
            }
            else
            {
                return Task.FromResult(CustomResponseDto<CountyDto>.Success(StatusCodes.Status200OK, city));
            }
        }

        public async Task<CustomResponseDto<NoContentDto>> RemoveAsync(int id)
        {
            var entity = await _countyRepository.GetByIdAsync(id);
            _countyRepository.Remove(entity);
            await _unitofwork.CommitAsync();
            await CacheAllCountyAsync();
            return CustomResponseDto<NoContentDto>.Success(StatusCodes.Status204NoContent);
        }

        public async Task<CustomResponseDto<NoContentDto>> RemoveRangeAsync(IEnumerable<int> ids)
        {
            var entites = await _countyRepository.Where(x => ids.Contains(x.Id)).ToListAsync();
            _countyRepository.RemoveRange(entites);
            await _unitofwork.CommitAsync();
            await CacheAllCountyAsync();
            return CustomResponseDto<NoContentDto>.Success(StatusCodes.Status204NoContent);
        }

        public async Task<CustomResponseDto<NoContentDto>> UpdateAsync(CountyDto dto)
        {
            var newEntity = _mapper.Map<County>(dto);
            _countyRepository.Update(newEntity);
            await _unitofwork.CommitAsync();
            await CacheAllCountyAsync();
            return CustomResponseDto<NoContentDto>.Success(StatusCodes.Status204NoContent);
        }

        public Task<CustomResponseDto<IEnumerable<CountyDto>>> Where(Expression<Func<County, bool>> expression)
        {
            var city = _mapper.Map<List<CountyDto>>(_memoryCache.Get<List<County>>(CacheCountyKey).Where(expression.Compile()).AsEnumerable());
            return Task.FromResult(CustomResponseDto<IEnumerable<CountyDto>>.Success(StatusCodes.Status200OK, city));
        }

        public async Task CacheAllCountyAsync()
        {
            _memoryCache.Set(CacheCountyKey, await _countyRepository.GetAll().ToListAsync());
        }
    }
}
