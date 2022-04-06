using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IEmployeeFamilyService
    {
        IDataResult<List<EmployeeFamily>> GetAll();
        IDataResult<List<EmployeeFamilyDto>> GetEmployeeFamilies();
        IDataResult<EmployeeFamily> GetEmployeeFamily(int id);
        IResult Add(EmployeeFamily employeeFamily);
        IResult Delete(EmployeeFamily employeeFamily);
        IResult Update(EmployeeFamily employeeFamily);
    }
}