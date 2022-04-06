using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IEmployeeEducationDal : IEntityRepository<EmployeeEducation>
    {
        List<EmployeeEducationDto> GetEmployeeEducationList(Expression<Func<EmployeeEducationDto, bool>> filter = null);
    }
}