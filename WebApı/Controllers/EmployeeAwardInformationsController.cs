using Business.Abstract;
using Business.Abstract.Items;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeAwardInformationsController : ControllerBase
    {
        private readonly IEmployeeAwardInformationService _employeeAwardInformationService;
        private readonly ITypeOfAwardService _typeOfAwardService;

        public EmployeeAwardInformationsController(IEmployeeAwardInformationService employeeAwardInformationService, ITypeOfAwardService typeOfAwardService)
        {
            _employeeAwardInformationService = employeeAwardInformationService;
            _typeOfAwardService = typeOfAwardService;
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

        [HttpGet("gettypeofawards")]
        public IActionResult GetTypeOfAwards()
        {
            var result = _typeOfAwardService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("gettypeofaward")]
        public IActionResult GetTypeOfAward(int id)
        {
            var result = _typeOfAwardService.GetById(id);
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

        [HttpPost("addtypeofaward")]
        public IActionResult AddTypeOfAward(TypeOfAward typeOfAward)
        {
            var result = _typeOfAwardService.Add(typeOfAward);
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

        [HttpPost("deletetypeofaward")]
        public IActionResult DeleteTypeOfAward(TypeOfAward typeOfAward)
        {
            var result = _typeOfAwardService.Delete(typeOfAward);
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

        [HttpPost("updatetypeofaward")]
        public IActionResult UpdateTypeOfAward(TypeOfAward typeOfAward)
        {
            var result = _typeOfAwardService.Update(typeOfAward);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
