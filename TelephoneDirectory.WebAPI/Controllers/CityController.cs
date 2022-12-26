using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TelephoneDirectory.Core.Models.Entities;
using TelephoneDirectory.Core.Services;
using TelephoneDirectory.Service.Services;
using TelephoneDirectory.WebAPI.Filters;

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

        [ServiceFilter(typeof(NotFoundFilter<City>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await _cityService.GetByIdAsync(id));
        }


        [HttpGet("/City{countryid}")]
        public async Task<IActionResult> GetCountryIdEqualsCity(int countryid)
        {
            return CreateActionResult(await _cityService.Where(x=>x.CountryId== countryid));
        }
    }
}
