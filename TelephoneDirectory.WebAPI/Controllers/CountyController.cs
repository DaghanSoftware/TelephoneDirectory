using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TelephoneDirectory.Core.Models.Entities;
using TelephoneDirectory.Core.Services;
using TelephoneDirectory.Service.Services;
using TelephoneDirectory.WebAPI.Filters;

namespace TelephoneDirectory.WebAPI.Controllers
{
    public class CountyController : CustomBaseController
    {
        private readonly ICountyService _countyService;

        public CountyController(ICountyService countyService)
        {
            _countyService = countyService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return CreateActionResult(await _countyService.GetAllAsync());
        }

        [ServiceFilter(typeof(NotFoundFilter<County>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await _countyService.GetByIdAsync(id));
        }

        [HttpGet("[action]/{cityId}")]
        public async Task<IActionResult> GetCityIdEqualsCountyies(int cityId)
        {
            return CreateActionResult(await _countyService.Where(x => x.CityId == cityId));
        }
    }
}
