using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IEmployeeComputerInformationService
    {
        IDataResult<List<EmployeeComputerInformationDto>> GetEmployeeComputerInformations();
        IDataResult<EmployeeComputerInformation> GetEmployeeComputerInformation(int id);
        IResult Add(EmployeeComputerInformation employeeComputerInformation);
        IResult Delete(EmployeeComputerInformation employeeComputerInformation);
        IResult Update(EmployeeComputerInformation employeeComputerInformation);
    }
}
