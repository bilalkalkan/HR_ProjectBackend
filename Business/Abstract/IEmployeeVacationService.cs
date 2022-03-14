using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IEmployeeVacationService
    {
        IDataResult<List<EmployeeVacation>> GetAll();
        IDataResult<EmployeeVacation> Get(int id);
        IResult Add(EmployeeVacation employeeVacation);
        IResult Delete(EmployeeVacation employeeVacation);
        IResult Update(EmployeeVacation employeeVacation);
    }
}