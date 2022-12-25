using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory.Core.Models.DTOs
{
    public class InstitutionWithOtherTableDto:InstitutionDto
    {
        public CategoryDto Category { get; set; }
        public CountryDto Country { get; set; }
        public CityDto City { get; set; }
        public CountyDto County { get; set; }
        public MainInstitutionDto MainInstitution { get; set; }

    }
}
