using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IEmployeeAwardInformationService
    {
        IDataResult<List<EmployeeAwardInformationDto>> GetEmployeeAwardInformations();
        IDataResult<EmployeeAwardInformation> GetEmployeeAwardInformation(int id);
        IResult Add(EmployeeAwardInformation employeeAwardInformation);
        IResult Update(EmployeeAwardInformation employeeAwardInformation);
        IResult Delete(EmployeeAwardInformation employeeAwardInformation);
    }
}
