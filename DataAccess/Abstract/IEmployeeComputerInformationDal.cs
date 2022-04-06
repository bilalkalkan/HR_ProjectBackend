using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IEmployeeComputerInformationDal:IEntityRepository<EmployeeComputerInformation>
    {
        List<EmployeeComputerInformationDto> GetEmployeeComputerInformationList(
            Expression<Func<EmployeeComputerInformationDto, bool>> filter = null);
    }
}
