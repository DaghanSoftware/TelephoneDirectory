using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory.Core.Models.DTOs
{
    public class CountryDto:BaseDto
    {
        public string Name { get; set; }
        public string Iso { get; set; }
        public string NiceName { get; set; }
        public string Iso3 { get; set; }
        public int NumCode { get; set; }
        public int PhoneCode { get; set; }
        public bool Active { get; set; }
    }
}
