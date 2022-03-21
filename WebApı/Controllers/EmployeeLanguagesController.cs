using Business.Abstract;
using Business.Abstract.Items;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeLanguagesController : ControllerBase
    {
        private readonly IEmployeeLanguageService _employeeLanguageService;
        private readonly ILanguageService _languageService;

        public EmployeeLanguagesController(IEmployeeLanguageService employeeLanguageService, ILanguageService languageService)
        {
            _employeeLanguageService = employeeLanguageService;
            _languageService = languageService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _employeeLanguageService.GetEmployeeLanguages();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }



        [HttpGet("getlanguages")]
        public IActionResult GetLanguages()
        {
            var result = _languageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _employeeLanguageService.GetEmployeeLanguage(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getlanguage")]
        public IActionResult GetLanguage(int id)
        {
            var result = _languageService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(EmployeeLanguage employeeLanguage)
        {
            var result = _employeeLanguageService.Add(employeeLanguage);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("addlanguage")]
        public IActionResult AddLanguage(Language language)
        {
            var result = _languageService.Add(language);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(EmployeeLanguage employeeLanguage)
        {
            var result = _employeeLanguageService.Delete(employeeLanguage);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("deletelanguage")]
        public IActionResult DeleteLanguage(Language language)
        {
            var result = _languageService.Delete(language);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(EmployeeLanguage employeeLanguage)
        {
            var result = _employeeLanguageService.Update(employeeLanguage);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("updatelanguage")]
        public IActionResult UpdateLanguage(Language language)
        {
            var result = _languageService.Update(language);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
