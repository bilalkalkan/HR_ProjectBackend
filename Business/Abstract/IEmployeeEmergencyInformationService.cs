using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IEmployeeEmergencyInformationService
    {
        IDataResult<List<EmployeeEmergencyInformation>> GetEmployeeEmergencyInformations();
        IDataResult<EmployeeEmergencyInformation> GetEmployeeEmergencyInformation(int id);
        IResult Add(EmployeeEmergencyInformation employeeEmergencyInformation);
        IResult Delete(EmployeeEmergencyInformation employeeEmergencyInformation);
        IResult Update(EmployeeEmergencyInformation employeeEmergencyInformation);
    }
}
