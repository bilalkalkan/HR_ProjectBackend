using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        IDataResult<List<Employee>> GetEmployees();
        IDataResult<Employee> GetEmployee(int id);
        IResult Add(Employee employee);
        IResult Update(Employee employee);
        IResult Delete(Employee employee);

    }
}