﻿using TelephoneDirectory.Core.Models.DTOs;
using TelephoneDirectory.Core.Models.Entities;

namespace TelephoneDirectory.Core.Services
{
    public interface IProductServiceWithDto : IServiceWithDto<Product, ProductDto>
    {
        Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategory();
        Task<CustomResponseDto<NoContentDto>> UpdateAsync(ProductUpdateDto dto);
        Task<CustomResponseDto<ProductDto>> AddAsync(ProductCreateDto dto);
    }
}
