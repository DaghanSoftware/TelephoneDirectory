using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TelephoneDirectory.Core.Models.DTOs;
using TelephoneDirectory.Core.Models.Entities;
using TelephoneDirectory.Core.Services;
using TelephoneDirectory.Service.Services;
using TelephoneDirectory.WebAPI.Filters;

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

        [ServiceFilter(typeof(NotFoundFilter<Country>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await _countryService.GetByIdAsync(id));
        }

        [HttpGet("/CountryTurkey")]
        public async Task<IActionResult> Where()
        {
            return CreateActionResult(await _countryService.Where(x => x.Name == "TURKEY"));
        }
    }
}
