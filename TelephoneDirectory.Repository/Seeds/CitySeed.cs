using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TelephoneDirectory.Core.Models.Entities;

namespace TelephoneDirectory.Repository.Seeds
{
    public class CitySeed : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(
                new City {Id= 1,Title= "ADANA",Latitude=37.00000000,Longitude= 35.32133330,NortheastLat= 37.07200400,NortheastLng =35.46199500,SouthwestLat= 36.93552300,SouthwestLng =35.17470600}
            );
        }
    }
}
