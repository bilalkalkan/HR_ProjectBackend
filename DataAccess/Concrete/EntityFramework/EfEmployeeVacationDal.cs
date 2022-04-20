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
    public class EfEmployeeVacationDal : EfEntityRepositoryBase<EmployeeVacation, HrContext>, IEmployeeVacationDal
    {
        public List<EmployeeVacationDto> GetEmployeeVacationList(Expression<Func<EmployeeVacationDto, bool>> filter = null)
        {
            using (HrContext context = new HrContext())
            {
                var result = from employeeVacation in context.EmployeeVacations
                             join employee in context.Employees on employeeVacation.EmployeeId equals employee.Id
                             join allowanceType in context.AllowanceTypes on employeeVacation.AllowanceTypeId equals allowanceType.Id
                             select new EmployeeVacationDto
                             {
                                 Id = employeeVacation.Id,
                                 EmployeeId = employee.Id,
                                 EmployeeFirstName = employee.FirstName,
                                 EmployeeLastName = employee.LastName,
                                 AllowanceTypeName = allowanceType.AllowanceTypeName,
                                 AllowanceStartingDate = employeeVacation.AllowanceStartingDate,
                                 AllowanceExpirationDate = employeeVacation.AllowanceExpirationDate,
                                 AllowanceNumberOfDays = employeeVacation.AllowanceNumberOfDays,
                                 AddressToBeAllowed = employeeVacation.AddressToBeAllowed,
                                 Statement = employeeVacation.Statement
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }
    }
}