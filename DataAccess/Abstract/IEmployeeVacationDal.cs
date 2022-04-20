using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IEmployeeVacationDal : IEntityRepository<EmployeeVacation>
    {
        List<EmployeeVacationDto> GetEmployeeVacationList(Expression<Func<EmployeeVacationDto,bool>>filter=null);
    }
}