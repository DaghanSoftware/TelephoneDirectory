using AutoMapper;
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

namespace TelephoneDirectory.Caching
{
    public class CityServiceWithCaching : ICityService
    {
        private const string CacheCountryKey = "categoriesCache";
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
        }

        public Task<CustomResponseDto<CityDto>> AddAsync(CityDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<CustomResponseDto<IEnumerable<CityDto>>> AddRangeAsync(IEnumerable<CityDto> dtos)
        {
            throw new NotImplementedException();
        }

        public Task<CustomResponseDto<bool>> AnyAsync(Expression<Func<City, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<CustomResponseDto<IEnumerable<CityDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CustomResponseDto<CityDto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CustomResponseDto<NoContentDto>> RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CustomResponseDto<NoContentDto>> RemoveRangeAsync(IEnumerable<int> ids)
        {
            throw new NotImplementedException();
        }

        public Task<CustomResponseDto<NoContentDto>> UpdateAsync(CityDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<CustomResponseDto<IEnumerable<CityDto>>> Where(Expression<Func<City, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
