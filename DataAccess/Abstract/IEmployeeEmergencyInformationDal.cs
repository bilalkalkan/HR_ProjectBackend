using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IEmployeeEmergencyInformationDal:IEntityRepository<EmployeeEmergencyInformation>
    {
        List<EmployeeEmergencyInformationDto> GetEmployeeEmergencyInformationlist(
            Expression<Func<EmployeeEmergencyInformationDto, bool>> filter = null);
    }
}
