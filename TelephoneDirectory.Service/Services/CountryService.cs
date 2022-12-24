using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectory.Core.Models.DTOs;
using TelephoneDirectory.Core.Models.Entities;
using TelephoneDirectory.Core.Repositories;
using TelephoneDirectory.Core.Services;
using TelephoneDirectory.Core.UnitOfWorks;

namespace TelephoneDirectory.Service.Services
{
    public class CountryService : ServiceWithDto<Country, CountryDto>, ICountryService
    {
        private readonly ICountryRepository _countryRepository;

        public CountryService(IGenericRepository<Country> repository, IUnitOfWork unitOfWork, IMapper mapper, ICountryRepository countryRepository) : base(repository, unitOfWork, mapper)
        {
            _countryRepository = countryRepository;
        }
    }
}
