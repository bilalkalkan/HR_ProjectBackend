using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IEmployeeComputerInformationService
    {
        IDataResult<List<EmployeeComputerInformation>> GetEmployeeComputerInformations();
        IDataResult<EmployeeComputerInformation> GetEmployeeComputerInformation(int id);
        IResult Add(EmployeeComputerInformation employeeComputerInformation);
        IResult Delete(EmployeeComputerInformation employeeComputerInformation);
        IResult Update(EmployeeComputerInformation employeeComputerInformation);
    }
}
