using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeEmergencyInformationsController : ControllerBase
    {
        private readonly IEmployeeEmergencyInformationService _employeeEmergencyInformationService;

        public EmployeeEmergencyInformationsController(IEmployeeEmergencyInformationService employeeEmergencyInformationService)
        {
            _employeeEmergencyInformationService = employeeEmergencyInformationService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _employeeEmergencyInformationService.GetEmployeeEmergencyInformations();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _employeeEmergencyInformationService.GetEmployeeEmergencyInformation(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(EmployeeEmergencyInformation employeeEmergencyInformation)
        {
            var result = _employeeEmergencyInformationService.Add(employeeEmergencyInformation);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("delete")]
        public IActionResult Delete(EmployeeEmergencyInformation employeeEmergencyInformation)
        {
            var result = _employeeEmergencyInformationService.Delete(employeeEmergencyInformation);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("update")]
        public IActionResult Update(EmployeeEmergencyInformation employeeEmergencyInformation)
        {
            var result = _employeeEmergencyInformationService.Update(employeeEmergencyInformation);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
