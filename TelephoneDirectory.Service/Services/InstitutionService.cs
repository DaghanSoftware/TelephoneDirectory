using AutoMapper;
using Microsoft.AspNetCore.Http;
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
using TelephoneDirectory.Repository.Repositories;

namespace TelephoneDirectory.Service.Services
{
    public class InstitutionService : ServiceWithDto<Institution, InstitutionDto>, IInstitutionService
    {
        private readonly IInstitutionRepository _institutionRepository;
        public InstitutionService(IGenericRepository<Institution> repository, IUnitOfWork unitOfWork, IMapper mapper, IInstitutionRepository institutionRepository) : base(repository, unitOfWork, mapper)
        {
            _institutionRepository = institutionRepository;
        }

        public async Task<CustomResponseDto<InstitutionDto>> AddAsync(InstitutionCreateDto dto)
        {
            var newEntity= _mapper.Map<Institution>(dto);
            await _institutionRepository.AddAsync(newEntity);
            await _unitOfWork.CommitAsync();
            var newDto = _mapper.Map<InstitutionDto>(newEntity);
            return CustomResponseDto<InstitutionDto>.Success(StatusCodes.Status200OK, newDto);
        }

        public async Task<CustomResponseDto<IEnumerable<InstitutionDto>>> AddRangeAsync(IEnumerable<InstitutionCreateDto> entities)
        {
            var newEntity = _mapper.Map<IEnumerable<Institution>>(entities);
            await _institutionRepository.AddRangeAsync(newEntity);
            await _unitOfWork.CommitAsync();
            var newDto = _mapper.Map<List<InstitutionDto>>(newEntity);
            return CustomResponseDto<IEnumerable<InstitutionDto>>.Success(StatusCodes.Status200OK, newDto);
        }

        //public Task<CustomResponseDto<List<InstitutionWithOtherTableDto>>> GetInstitutionWithAllTable()
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<CustomResponseDto<NoContentDto>> UpdateAsync(InstitutionUpdateDto dto)
        {
            var entity = _mapper.Map<Institution>(dto);
            _institutionRepository.Update(entity);
            await _unitOfWork.CommitAsync();
            return CustomResponseDto<NoContentDto>.Success(StatusCodes.Status204NoContent);
        }
    }
}
