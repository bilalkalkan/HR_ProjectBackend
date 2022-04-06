using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IEmployeeLanguageDal : IEntityRepository<EmployeeLanguage>
    {
        List<EmployeeLanguageDto> GetEmployeeLanguagelist(Expression<Func<EmployeeLanguageDto,bool>>filter=null);
    }
}