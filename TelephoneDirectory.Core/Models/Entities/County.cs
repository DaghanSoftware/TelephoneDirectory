﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory.Core.Models.Entities
{
    public class County:BaseEntity
    {
        public int CityId { get; set; }
        public string Title { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public decimal NortheastLat { get; set; }
        public decimal NortheastLng { get; set; }
        public decimal SouthwestLat { get; set; }
        public decimal SouthwestLng { get; set; }

        public City Cities { get; set; }
    }
}
