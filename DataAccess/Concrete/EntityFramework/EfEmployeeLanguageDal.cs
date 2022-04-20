using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeLanguageDal : EfEntityRepositoryBase<EmployeeLanguage, HrContext>, IEmployeeLanguageDal
    {
        public List<EmployeeLanguageDto> GetEmployeeLanguagelist(Expression<Func<EmployeeLanguageDto, bool>> filter = null)
        {
            using (HrContext context = new HrContext())
            {
                var result = from employeeLanguage in context.EmployeeLanguages
                             join employee in context.Employees on employeeLanguage.EmployeeId equals employee.Id
                             join language in context.Languages on employeeLanguage.ForeignLanguageId equals language.Id
                             select new EmployeeLanguageDto
                             {
                                 Id = employeeLanguage.Id,
                                 EmployeeId = employee.Id,
                                 EmployeeFirstName = employee.FirstName,
                                 EmployeeLastName = employee.LastName,
                                 ForeignLanguageName = language.NameOfLanguage,
                                 Reading = employeeLanguage.Reading,
                                 Writing = employeeLanguage.Writing,
                                 Talking = employeeLanguage.Talking
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}