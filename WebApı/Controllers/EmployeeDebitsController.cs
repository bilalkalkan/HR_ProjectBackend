using Business.Abstract;
using Business.Abstract.Items;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDebitsController : ControllerBase
    {
        private readonly IEmployeeDebitService _employeeDebitService;
        private readonly IDebitTypeService _debitTypeService;

        public EmployeeDebitsController(IEmployeeDebitService employeeDebitService, IDebitTypeService debitTypeService)
        {
            _employeeDebitService = employeeDebitService;
            _debitTypeService = debitTypeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _employeeDebitService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getdebittypes")]
        public IActionResult GetDebitTypes()
        {
            var result = _debitTypeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _employeeDebitService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpGet("getdebittype")]
        public IActionResult GetDebitType(int id)
        {
            var result = _debitTypeService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(EmployeeDebit employeeDebit)
        {
            var result = _employeeDebitService.Add(employeeDebit);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("adddetbittype")]
        public IActionResult AddDebitType(DebitType debitType)
        {
            var result = _debitTypeService.Add(debitType);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(EmployeeDebit employeeDebit)
        {
            var result = _employeeDebitService.Delete(employeeDebit);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("deletedetbittype")]
        public IActionResult DeleteDebitType(DebitType debitType)
        {
            var result = _debitTypeService.Delete(debitType);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(EmployeeDebit employeeDebit)
        {
            var result = _employeeDebitService.Update(employeeDebit);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("updatedetbittype")]
        public IActionResult UpdateDebitType(DebitType debitType)
        {
            var result = _debitTypeService.Update(debitType);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
