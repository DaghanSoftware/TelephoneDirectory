using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TelephoneDirectory.Core.Models.Entities;

namespace TelephoneDirectory.Repository.Seeds
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, Name = "Şirketler" },
                new Category { Id = 2, Name = "Üniversiteler" },
                new Category { Id = 3, Name = "Sağlık Kuruluşları" },
                new Category { Id = 4, Name = "Oteller" }
            );
        }
    }
}
