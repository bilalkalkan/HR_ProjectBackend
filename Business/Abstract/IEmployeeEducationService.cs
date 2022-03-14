using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IEmployeeEducationService
    {
        IDataResult<List<EmployeeEducation>> GetAll();
        IDataResult<EmployeeEducation> Get(int id);
        IResult Add(EmployeeEducation employeeEducation);
        IResult Update(EmployeeEducation employeeEducation);
        IResult Delete(EmployeeEducation employeeEducation);

    }
}