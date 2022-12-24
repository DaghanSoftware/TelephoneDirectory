using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TelephoneDirectory.Core.Services;
using TelephoneDirectory.Service.Services;

namespace TelephoneDirectory.WebAPI.Controllers
{
    public class CityController : CustomBaseController
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return CreateActionResult(await _cityService.GetAllAsync());
        }
    }
}
