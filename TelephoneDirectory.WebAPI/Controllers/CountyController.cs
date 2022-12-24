using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TelephoneDirectory.Core.Services;
using TelephoneDirectory.Service.Services;

namespace TelephoneDirectory.WebAPI.Controllers
{
    public class CountyController : CustomBaseController
    {
        private readonly ICountryService _countyService;

        public CountyController(ICountryService countyService)
        {
            _countyService = countyService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return CreateActionResult(await _countyService.GetAllAsync());
        }
    }
}
