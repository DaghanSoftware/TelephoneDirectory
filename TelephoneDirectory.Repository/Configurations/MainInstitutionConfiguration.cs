using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TelephoneDirectory.Core.Models.Entities;

namespace TelephoneDirectory.Repository.Configurations
{
    public class MainInstitutionConfiguration : IEntityTypeConfiguration<MainInstitution>
    {
        public void Configure(EntityTypeBuilder<MainInstitution> builder)
        {
            builder.ToTable("MainInstitutions");
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
        }
    }
}
