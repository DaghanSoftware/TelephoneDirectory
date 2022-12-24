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
    public class MainInstitutionService : ServiceWithDto<MainInstitution, MainInstitutionDto>, IMainInstitutionService
    {
        private readonly IMainInstitutionRepository _mainInstitutionRepository;

        public MainInstitutionService(IGenericRepository<MainInstitution> repository, IUnitOfWork unitOfWork, IMapper mapper, IMainInstitutionRepository mainInstitutionRepository) : base(repository, unitOfWork, mapper)
        {
            _mainInstitutionRepository = mainInstitutionRepository;
        }
    }
}
