using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IEmployeeFamilyService
    {
        IDataResult<List<EmployeeFamily>> GetEmployeeFamilies();
        IDataResult<EmployeeFamily> GetEmployeeFamily(int id);
        IResult Add(EmployeeFamily employeeFamily);
        IResult Delete(EmployeeFamily employeeFamily);
        IResult Update(EmployeeFamily employeeFamily);
    }
}