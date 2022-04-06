using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IEmployeeEducationService
    {
        IDataResult<List<EmployeeEducationDto>> GetEmployeeEducations();
        IDataResult<EmployeeEducation> GetEmployeeEducation(int id);
        IResult Add(EmployeeEducation employeeEducation);
        IResult Update(EmployeeEducation employeeEducation);
        IResult Delete(EmployeeEducation employeeEducation);

    }
}