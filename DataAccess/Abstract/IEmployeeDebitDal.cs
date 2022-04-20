using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IEmployeeDebitDal : IEntityRepository<EmployeeDebit>
    {
        List<EmployeeDebitDto> GetEmployeeDebitList(Expression<Func<EmployeeDebitDto, bool>> filter = null);
    }
}