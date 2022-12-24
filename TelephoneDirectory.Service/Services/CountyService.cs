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
    public class CountyService : ServiceWithDto<County, CountyDto>, ICountyService
    {
        private readonly ICountyRepository _countyRepository;

        public CountyService(IGenericRepository<County> repository, IUnitOfWork unitOfWork, IMapper mapper, ICountyRepository countyRepository) : base(repository, unitOfWork, mapper)
        {
            _countyRepository = countyRepository;
        }
    }
}
