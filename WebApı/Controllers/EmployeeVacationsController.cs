using Business.Abstract;
using Business.Abstract.Items;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeVacationsController : ControllerBase
    {
        private readonly IEmployeeVacationService _employeeVacationService;
        private readonly IAllowanceTypeService _allowanceTypeService;

        public EmployeeVacationsController(IEmployeeVacationService employeeVacationService, IAllowanceTypeService allowanceTypeService)
        {
            _employeeVacationService = employeeVacationService;
            _allowanceTypeService = allowanceTypeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _employeeVacationService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpGet("getallowancetypes")]
        public IActionResult GetAllowanceTypes()
        {
            var result = _allowanceTypeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _employeeVacationService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpGet("getallowancetype")]
        public IActionResult GetAllowanceType(int id)
        {
            var result = _allowanceTypeService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpPost("add")]
        public IActionResult Add(EmployeeVacation employeeVacation)
        {
            var result = _employeeVacationService.Add(employeeVacation);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpPost("addallowancetype")]
        public IActionResult AddAllowanceType(AllowanceType allowanceType)
        {
            var result = _allowanceTypeService.Add(allowanceType);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpPost("delete")]
        public IActionResult Delete(EmployeeVacation employeeVacation)
        {
            var result = _employeeVacationService.Delete(employeeVacation);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }


        [HttpPost("deleteallowancetype")]
        public IActionResult DeleteAllowanceType(AllowanceType allowanceType)
        {
            var result = _allowanceTypeService.Delete(allowanceType);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpPost("update")]
        public IActionResult Update(EmployeeVacation employeeVacation)
        {

            var result = _employeeVacationService.Update(employeeVacation);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }


        [HttpGet("updateallowancetype")]
        public IActionResult UpdateAllowanceType(AllowanceType allowanceType)
        {
            var result = _allowanceTypeService.Update(allowanceType);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }
    }
}
