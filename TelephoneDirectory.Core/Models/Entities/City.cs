using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory.Core.Models.Entities
{
    public class City:BaseEntity
    {
        public string Title { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double NortheastLat { get; set; }
        public double NortheastLng { get; set; }
        public double SouthwestLat { get; set; }
        public double SouthwestLng { get; set; }
        public int CountryId { get; set; }

        public Country Countries { get; set; }
        public ICollection<County> Counties { get; set; }
        
    }
}
