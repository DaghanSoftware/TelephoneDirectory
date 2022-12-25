using AutoMapper;
using TelephoneDirectory.Core.Models.DTOs;
using TelephoneDirectory.Core.Models.Entities;

namespace TelephoneDirectory.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<City, CityDto>().ReverseMap();
            CreateMap<County, CountyDto>().ReverseMap();
            CreateMap<MainInstitution, MainInstitutionDto>().ReverseMap();

            CreateMap<Institution, InstitutionDto>().ReverseMap();
            CreateMap<InstitutionCreateDto, Institution>();
            CreateMap<InstitutionUpdateDto, Institution>();

            CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>();
            CreateMap<Product, ProductWithCategoryDto>();
            CreateMap<Category, CategoryWithProductsDto>();
            CreateMap<ProductCreateDto, Product>();
        }
    }
}
