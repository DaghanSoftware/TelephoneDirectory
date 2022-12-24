using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TelephoneDirectory.Core.Services;
using TelephoneDirectory.Service.Services;

namespace TelephoneDirectory.WebAPI.Controllers
{
    public class MainInstitutionController : CustomBaseController
    {
        private readonly IMainInstitutionService _mainInstitutionService;

        public MainInstitutionController(IMainInstitutionService mainInstitutionService)
        {
            _mainInstitutionService = mainInstitutionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return CreateActionResult(await _mainInstitutionService.GetAllAsync());
        }
    }
}
