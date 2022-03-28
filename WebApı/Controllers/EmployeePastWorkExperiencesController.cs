using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeePastWorkExperiencesController : ControllerBase
    {
        private readonly IEmployeePastWorkExperienceService _employeePastWorkExperienceService;

        public EmployeePastWorkExperiencesController(IEmployeePastWorkExperienceService employeePastWorkExperienceService)
        {
            _employeePastWorkExperienceService = employeePastWorkExperienceService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _employeePastWorkExperienceService.GetEmployeePastWorkExperiences();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _employeePastWorkExperienceService.GetEmployeePastWorkExperience(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(EmployeePastWorkExperience employeePastWorkExperience)
        {
            var result = _employeePastWorkExperienceService.Add(employeePastWorkExperience);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(EmployeePastWorkExperience employeePastWorkExperience)
        {
            var result = _employeePastWorkExperienceService.Delete(employeePastWorkExperience);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(EmployeePastWorkExperience employeePastWorkExperience)
        {
            var result = _employeePastWorkExperienceService.Update(employeePastWorkExperience);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
