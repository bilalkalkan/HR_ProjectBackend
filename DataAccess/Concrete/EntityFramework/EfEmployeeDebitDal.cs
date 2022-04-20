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
    public class EfEmployeeDebitDal : EfEntityRepositoryBase<EmployeeDebit, HrContext>, IEmployeeDebitDal
    {
        public List<EmployeeDebitDto> GetEmployeeDebitList(Expression<Func<EmployeeDebitDto, bool>> filter = null)
        {
            using (HrContext context = new HrContext())
            {
                var result = from employeeDebit in context.EmployeeDebits
                             join employee in context.Employees on employeeDebit.EmployeeId equals employee.Id
                             join debitType in context.DebitTypes on employeeDebit.DebitTypeId equals debitType.Id 
                             select new EmployeeDebitDto
                             {
                                 Id = employeeDebit.Id,
                                 EmployeeId = employee.Id,
                                 EmployeeFirstName = employee.FirstName,
                                 EmployeeLastName = employee.LastName,
                                 DebitTypeId = debitType.Id,
                                 DebitTypeName = debitType.DebitTypeName,
                                 DebitDeliveryDate = employeeDebit.DebitDeliveryDate,
                                 DebitReturnStatus = employeeDebit.DebitReturnStatus,
                                 DebitReturnDate = employeeDebit.DebitReturnDate,
                                 DebitStatement = employeeDebit.DebitStatement
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();


            }
        }
    }
}