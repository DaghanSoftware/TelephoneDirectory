using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectory.Core.Models.DTOs;
using TelephoneDirectory.Core.Models.Entities;

namespace TelephoneDirectory.Core.Services
{
    public interface IServiceWithDto<Entity,Dto> where Entity:BaseEntity where Dto:class
    {
        Task<CustomResponseDto<Dto>> GetByIdAsync(int id);

        Task<IEnumerable<CustomResponseDto<Dto>>> GetAllAsync();

        Task<IEnumerable<CustomResponseDto<Dto>>> Where(Expression<Func<Entity, bool>> expression);

        Task<CustomResponseDto<bool>> AnyAsync(Expression<Func<Entity, bool>> expression);

        Task<CustomResponseDto<Dto>> AddAsync(Dto dto);

        Task<CustomResponseDto<IEnumerable<Dto>>> AddRangeAsync(IEnumerable<Dto> dto);

        Task<CustomResponseDto<NoContentDto>> UpdateAsync(Dto dto);

        Task<CustomResponseDto<NoContentDto>> RemoveAsync(int id);

        Task<CustomResponseDto<NoContentDto>> RemoveRangeAsync(IEnumerable<int> ids);
    }
}
