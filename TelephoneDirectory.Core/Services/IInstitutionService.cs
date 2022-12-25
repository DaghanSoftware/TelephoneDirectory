using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectory.Core.Models.DTOs;
using TelephoneDirectory.Core.Models.Entities;

namespace TelephoneDirectory.Core.Services
{
    public interface IInstitutionService : IServiceWithDto<Institution, InstitutionDto>
    {
        //Task<CustomResponseDto<List<InstitutionWithOtherTableDto>>> GetInstitutionWithAllTable();
        Task<CustomResponseDto<NoContentDto>> UpdateAsync(InstitutionUpdateDto dto);
        Task<CustomResponseDto<InstitutionDto>> AddAsync(InstitutionCreateDto dto);
        Task<CustomResponseDto<IEnumerable<InstitutionDto>>> AddRangeAsync(IEnumerable<InstitutionCreateDto> entities);
    }
}
