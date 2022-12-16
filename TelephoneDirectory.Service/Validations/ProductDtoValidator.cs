using FluentValidation;
using TelephoneDirectory.Core.Models.DTOs;

namespace TelephoneDirectory.Service.Validations
{
    public class ProductDtoValidator : AbstractValidator<ProductDto>
    {
        public ProductDtoValidator()
        {
            RuleFor(p => p.Name).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.Price).InclusiveBetween(1,int.MaxValue).WithMessage("{PropertyName} must be greater 0");
            RuleFor(x => x.Stock).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater 0");
            RuleFor(x => x.CategoryId).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater 0");
        }
    }
}
