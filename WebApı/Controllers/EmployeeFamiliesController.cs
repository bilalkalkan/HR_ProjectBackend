using Business.Abstract;
using Business.Abstract.Items;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeFamiliesController : ControllerBase
    {
        private readonly IEmployeeFamilyService _employeeFamilyService;
        private readonly IFamilyMemberService _familyMemberService;

        public EmployeeFamiliesController(IEmployeeFamilyService employeeFamilyService, IFamilyMemberService familyMemberService)
        {
            _employeeFamilyService = employeeFamilyService;
            _familyMemberService = familyMemberService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _employeeFamilyService.GetEmployeeFamilies();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getfamilymembers")]
        public IActionResult GetFamilyMembers()
        {
            var result = _familyMemberService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _employeeFamilyService.GetEmployeeFamily(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getfamilymember")]
        public IActionResult GetFamilyMember(int id)
        {
            var result = _familyMemberService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(EmployeeFamily employeeFamily)
        {
            var result = _employeeFamilyService.Add(employeeFamily);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("addfamilymember")]
        public IActionResult AddFamilyMember(FamilyMember familyMember)
        {
            var result = _familyMemberService.Add(familyMember);
            if (result.Success)
            {
                return Ok(result);

            }

            return BadRequest(result);
        }


        [HttpPost("delete")]
        public IActionResult Delete(EmployeeFamily employeeFamily)
        {
            var result = _employeeFamilyService.Delete(employeeFamily);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("deletefamilymember")]
        public IActionResult DeleteFamilyMember(FamilyMember familyMember)
        {
            var result = _familyMemberService.Delete(familyMember);
            if (result.Success)
            {
                return Ok(result);

            }

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(EmployeeFamily employeeFamily)
        {
            var result = _employeeFamilyService.Update(employeeFamily);
            if (result.Success)
            {
                return Ok(result);

            }

            return BadRequest(result);
        }

        [HttpPost("updatefamilymember")]
        public IActionResult UpdateFamilyMember(FamilyMember familyMember)
        {
            var result = _familyMemberService.Update(familyMember);
            if (result.Success)
            {
                return Ok(result);

            }

            return BadRequest(result);
        }
    }
}
