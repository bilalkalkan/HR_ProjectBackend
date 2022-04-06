using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IEmployeeContactInformationDal:IEntityRepository<EmployeeContactInformation>
    {
        List<EmployeeContactInformationDto> GetEmployeeContactInformationList(Expression<Func<EmployeeContactInformationDto,bool>>filter=null);
    }
}
