using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TelephoneDirectory.Core.Services;
using TelephoneDirectory.Service.Services;

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
    }
}
