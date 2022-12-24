using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TelephoneDirectory.Core.Services;
using TelephoneDirectory.Service.Services;

namespace TelephoneDirectory.WebAPI.Controllers
{
    public class CountryController : CustomBaseController
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return CreateActionResult(await _countryService.GetAllAsync());
        }
    }
}
