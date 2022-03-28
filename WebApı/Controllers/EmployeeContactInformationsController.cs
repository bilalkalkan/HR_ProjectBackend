using Business.Abstract;
using Business.Abstract.Items;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeContactInformationsController : ControllerBase
    {
        private readonly IEmployeeContactInformationService _employeeContactInformationService;
        private readonly ICountyService _countyService;
        private readonly ICityService _cityService;

        public EmployeeContactInformationsController(IEmployeeContactInformationService employeeContactInformationService, ICountyService countyService, ICityService cityService)
        {
            _employeeContactInformationService = employeeContactInformationService;
            _countyService = countyService;
            _cityService = cityService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _employeeContactInformationService.GetEmployeeContactInformations();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getcities")]
        public IActionResult GetCities()
        {
            var result = _cityService.GetCities();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getcounties")]
        public IActionResult GetCounties( )
        {
            var result = _countyService.GetCounties();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getcontiesbycityid")]
        public IActionResult GetCountiesByCityId(int cityId)
        {
            var result = _countyService.GetCountiesByCityId(cityId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _employeeContactInformationService.GetEmployeeContactInformation(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(EmployeeContactInformation employeeContactInformation)
        {
            var result = _employeeContactInformationService.Add(employeeContactInformation);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("delete")]
        public IActionResult Delete(EmployeeContactInformation employeeContactInformation)
        {
            var result = _employeeContactInformationService.Delete(employeeContactInformation);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("update")]
        public IActionResult Update(EmployeeContactInformation employeeContactInformation)
        {
            var result = _employeeContactInformationService.Update(employeeContactInformation);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
