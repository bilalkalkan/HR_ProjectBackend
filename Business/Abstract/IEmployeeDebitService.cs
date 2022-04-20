using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IEmployeeDebitService
    {
        IDataResult<List<EmployeeDebitDto>> GetEmployeeDebits();
        IDataResult<EmployeeDebit> GetEmployeeDebit(int id);
        IResult Add(EmployeeDebit employeeDebit);
        IResult Delete(EmployeeDebit employeeDebit);
        IResult Update(EmployeeDebit employeeDebit);
    }
}