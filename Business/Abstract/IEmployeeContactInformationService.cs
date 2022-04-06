using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IEmployeeContactInformationService
    {
        IDataResult<List<EmployeeContactInformationDto>> GetEmployeeContactInformations();
        IDataResult<EmployeeContactInformation> GetEmployeeContactInformation(int id);
        IResult Add(EmployeeContactInformation employeeContactInformation);
        IResult Delete(EmployeeContactInformation employeeContactInformation);
        IResult Update(EmployeeContactInformation employeeContactInformation);

    }
}
