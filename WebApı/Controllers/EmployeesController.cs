using Business.Abstract;
using Business.Abstract.Items;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly INationalityService _nationalityService;

        public EmployeesController(IEmployeeService employeeService, INationalityService nationalityService)
        {
            _employeeService = employeeService;
            _nationalityService = nationalityService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _employeeService.GetEmployees();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getallbyfilter")]
        public IActionResult GetAllByFilter(string gender, string nationality, string identificationNumber)
        {
            var result = _employeeService.GetAllByFilter(gender, nationality, identificationNumber);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getnationalities")]
        public IActionResult GetNationals()
        {
            var result = _nationalityService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _employeeService.GetEmployee(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getnationality")]
        public IActionResult GetNational(int id)
        {
            var result = _nationalityService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(Employee employee)
        {
            var result = _employeeService.Add(employee);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("addnationality")]
        public IActionResult AddNational(Nationality nationality)
        {
            var result = _nationalityService.Add(nationality);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Employee employee)
        {

            var result = _employeeService.Delete(employee);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("deletenationality")]
        public IActionResult DeleteNational(Nationality nationality)
        {
            var result = _nationalityService.Delete(nationality);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("update")]
        public IActionResult Update(Employee employee)
        {
            var result = _employeeService.Update(employee);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("updatenationality")]
        public IActionResult UpdateNational(Nationality nationality)
        {
            var result = _nationalityService.Update(nationality);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
