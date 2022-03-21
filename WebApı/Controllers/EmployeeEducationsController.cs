using Business.Abstract;
using Business.Abstract.Items;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeEducationsController : ControllerBase
    {
        private readonly IEmployeeEducationService _employeeEducationService;
        private readonly IEducationaLevelService _educationalLevelService;

        public EmployeeEducationsController(IEmployeeEducationService employeeEducationService, IEducationaLevelService educationalLevelService)
        {
            _employeeEducationService = employeeEducationService;
            _educationalLevelService = educationalLevelService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _employeeEducationService.GetEmployeeEducations();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("geteducationlevels")]
        public IActionResult GetEducationLevels()
        {
            var result = _educationalLevelService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _employeeEducationService.GetEmployeeEducation(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpGet("geteducationlevel")]
        public IActionResult GetEducationLeves(int id)
        {
            var result = _educationalLevelService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(EmployeeEducation employeeEducation)
        {
            var result = _employeeEducationService.Add(employeeEducation);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("addeducationlevel")]
        public IActionResult AddEducationLevel(EducationaLevel educationLevel)
        {
            var result = _educationalLevelService.Add(educationLevel);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("delete")]
        public IActionResult Delete(EmployeeEducation employeeEducation)
        {
            var result = _employeeEducationService.Delete(employeeEducation);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("deleteeducationlevel")]
        public IActionResult DeleteEducationLevel(EducationaLevel educationLevel)
        {
            var result = _educationalLevelService.Delete(educationLevel);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("update")]
        public IActionResult Update(EmployeeEducation employeeEducation)
        {
            var result = _employeeEducationService.Update(employeeEducation);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("updateeducationlevel")]
        public IActionResult UpdateEducationLevel(EducationaLevel educationLevel)
        {
            var result = _educationalLevelService.Update(educationLevel);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
