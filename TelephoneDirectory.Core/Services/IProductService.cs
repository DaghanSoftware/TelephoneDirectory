using TelephoneDirectory.Core.Models.DTOs;
using TelephoneDirectory.Core.Models.Entities;

namespace TelephoneDirectory.Core.Services
{
    public interface IProductService : IService<Product>
    {
        public Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategory();
    }
}
