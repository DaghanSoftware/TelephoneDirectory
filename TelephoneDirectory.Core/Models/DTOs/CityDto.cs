using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory.Core.Models.DTOs
{
    public class CityDto:BaseDto
    {
        public string Title { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double NortheastLat { get; set; }
        public double NortheastLng { get; set; }
        public double SouthwestLat { get; set; }
        public double SouthwestLng { get; set; }
        public int CountryId { get; set; }
    }
}
