using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        IDataResult<List<EmployeeDto>> GetEmployees();
        IDataResult<List<EmployeeDto>> GetAllByFilter(string gender, string nationalityName, string identificationNumber);
        IDataResult<Employee> GetEmployee(int id);
        IResult Add(Employee employee);
        IResult Update(Employee employee);
        IResult Delete(Employee employee);

    }
}