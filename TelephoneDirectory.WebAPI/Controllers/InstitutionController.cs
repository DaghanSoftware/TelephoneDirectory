using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TelephoneDirectory.Core.Models.DTOs;
using TelephoneDirectory.Core.Models.Entities;
using TelephoneDirectory.Core.Services;
using TelephoneDirectory.Service.Services;
using TelephoneDirectory.WebAPI.Filters;

namespace TelephoneDirectory.WebAPI.Controllers
{
    public class InstitutionController : CustomBaseController
    {
        private readonly IInstitutionService _institutionService;

        public InstitutionController(IInstitutionService InstitutionService)
        {
            _institutionService = InstitutionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return CreateActionResult(await _institutionService.GetAllAsync());
        }

        [ServiceFilter(typeof(NotFoundFilter<Institution>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await _institutionService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Save(InstitutionCreateDto institutionDto)
        {
            return CreateActionResult(await _institutionService.AddAsync(institutionDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(InstitutionUpdateDto institutionDto)
        {
            return CreateActionResult(await _institutionService.UpdateAsync(institutionDto));
        }

        [ServiceFilter(typeof(NotFoundFilter<Institution>))]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            return CreateActionResult(await _institutionService.RemoveAsync(id));
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> SaveAll(List<InstitutionCreateDto> institutionDto)
        {
            return CreateActionResult(await _institutionService.AddRangeAsync(institutionDto));
        }

        [HttpDelete("[action]")]
        public async Task<IActionResult> RemoveAll(List<int> ids)
        {
            return CreateActionResult(await _institutionService.RemoveRangeAsync(ids));
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> Any(int id)
        {
            return CreateActionResult(await _institutionService.AnyAsync(x => x.Id == id));
        }
    }
}
