using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory.Core.Models.DTOs
{
    public class InstitutionUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Explanation { get; set; }
        public int PhoneNumber1 { get; set; }
        public int PhoneNumber2 { get; set; }
        public int PhoneNumber3 { get; set; }
        public int FaxNumber1 { get; set; }
        public int FaxNumber2 { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string WebSite { get; set; }
        public int MainInstitutionId { get; set; }
        public int CategoryId { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public int CountyId { get; set; }
    }
}
