using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TelephoneDirectory.Core.Models.Entities;

namespace TelephoneDirectory.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, Name = "Kalem", Stock = 20, Price = 60, CategoryId = 1,CreateDate=DateTime.Now },
                new Product { Id = 2, Name = "Kağıt", Stock = 4, Price = 80, CategoryId = 1, CreateDate = DateTime.Now },
                new Product { Id = 3, Name = "Defter", Stock = 5, Price = 90, CategoryId = 2, CreateDate = DateTime.Now },
                new Product { Id = 4, Name = "Klavye", Stock = 6, Price = 100, CategoryId = 3, CreateDate = DateTime.Now },
                new Product { Id = 5, Name = "Mause", Stock = 7, Price = 215, CategoryId = 2, CreateDate = DateTime.Now }
            );
        }
    }
}
