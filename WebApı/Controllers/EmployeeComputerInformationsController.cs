using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeComputerInformationsController : ControllerBase
    {
        private readonly IEmployeeComputerInformationService _employeeComputerInformationService;

        public EmployeeComputerInformationsController(IEmployeeComputerInformationService employeeComputerInformationService)
        {
            _employeeComputerInformationService = employeeComputerInformationService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _employeeComputerInformationService.GetEmployeeComputerInformations();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _employeeComputerInformationService.GetEmployeeComputerInformation(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(EmployeeComputerInformation employeeComputerInformation)
        {
            var result = _employeeComputerInformationService.Add(employeeComputerInformation);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(EmployeeComputerInformation employeeComputerInformation)
        {
            var result = _employeeComputerInformationService.Delete(employeeComputerInformation);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(EmployeeComputerInformation employeeComputerInformation)
        {
            var result = _employeeComputerInformationService.Update(employeeComputerInformation);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
