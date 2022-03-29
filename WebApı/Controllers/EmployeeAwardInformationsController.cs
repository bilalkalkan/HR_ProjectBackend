using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeAwardInformationsController : ControllerBase
    {
        private readonly IEmployeeAwardInformationService _employeeAwardInformationService;

        public EmployeeAwardInformationsController(IEmployeeAwardInformationService employeeAwardInformationService)
        {
            _employeeAwardInformationService = employeeAwardInformationService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _employeeAwardInformationService.GetEmployeeAwardInformations();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _employeeAwardInformationService.GetEmployeeAwardInformation(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(EmployeeAwardInformation employeeAwardInformation)
        {
            var result = _employeeAwardInformationService.Add(employeeAwardInformation);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(EmployeeAwardInformation employeeAwardInformation)
        {
            var result = _employeeAwardInformationService.Delete(employeeAwardInformation);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(EmployeeAwardInformation employeeAwardInformation)
        {
            var result = _employeeAwardInformationService.Update(employeeAwardInformation);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

    }
}
