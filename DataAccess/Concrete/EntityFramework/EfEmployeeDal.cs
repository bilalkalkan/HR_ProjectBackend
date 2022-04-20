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
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, HrContext>, IEmployeeDal
    {
        public List<EmployeeDto> GetEmployeeList(Expression<Func<EmployeeDto, bool>> filter = null)
        {
            using (HrContext context = new HrContext())
            {
                var result = from employee in context.Employees
                             join nationality in context.Nationalities on employee.NationalityId equals nationality.Id
                             select new EmployeeDto()
                             {
                                 Id = employee.Id,
                                 FirstName = employee.FirstName,
                                 LastName = employee.LastName,
                                 IdentificationNumber = employee.IdentificationNumber,
                                 Gender = employee.Gender,
                                 NationalityId = nationality.Id,
                                 NationalityName = nationality.NationalityName,
                                 PlaceOfBirth = employee.PlaceOfBirth,
                                 DateOfBirth = employee.DateOfBirth,
                                 MaritalStatus = employee.MaritalStatus,
                                 RegistrationNumber = employee.RegistrationNumber,
                                 CompanyEntryDate = employee.CompanyEntryDate,
                                 SGKEntryDate = employee.SGKEntryDate,
                                 AnnualLeaveEntitlementStartDate = employee.AnnualLeaveEntitlementStartDate,
                                 AnnualLeaveGroup = employee.AnnualLeaveGroup,
                                 SeverancePayStartDate = employee.SeverancePayStartDate,
                                 OYAKStartDateOfWork = employee.OYAKStartDateOfWork,
                                 FirstDateOfJoiningTheGroup = employee.FirstDateOfJoiningTheGroup,
                                 Wage = employee.Wage,
                                 TypeOfWage = employee.TypeOfWage,
                                 TypeOfPayment = employee.TypeOfPayment,
                                 PaymentCurrency = employee.PaymentCurrency
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}