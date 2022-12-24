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
    public class InstitutionService : ServiceWithDto<Institution, InstitutionDto>, IInstitutionService
    {
        private readonly IInstitutionRepository _institutionRepository;
        public InstitutionService(IGenericRepository<Institution> repository, IUnitOfWork unitOfWork, IMapper mapper, IInstitutionRepository institutionRepository) : base(repository, unitOfWork, mapper)
        {
            _institutionRepository = institutionRepository;
        }
    }
}
