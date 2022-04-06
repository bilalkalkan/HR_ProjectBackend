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
    public class EfEmployeeFamilyDal : EfEntityRepositoryBase<EmployeeFamily, HrContext>, IEmployeeFamilyDal
    {
        public List<EmployeeFamilyDto> GetEmployeeFamilies(Expression<Func<EmployeeFamilyDto, bool>> filter = null)
        {
            using (HrContext context=new HrContext())
            {
                var result = from employeeFamily in context.EmployeeFamilies
                    join employee in context.Employees on employeeFamily.EmployeeId equals employee.Id
                    select new EmployeeFamilyDto
                    {
                        Id = employeeFamily.Id,
                        EmployeeId = employee.Id,
                        EmployeeFirstName = employee.FirstName,
                        EmployeeLastName = employee.LastName,
                        Degree = employeeFamily.Degree,
                        FirstName = employeeFamily.FirstName,
                        LastName = employeeFamily.LastName,
                        Gender = employeeFamily.Gender,
                        DateOfBirth = employeeFamily.DateOfBirth,
                        IdentificationNumber = employeeFamily.IdentificationNumber,
                        EducationalStatus = employeeFamily.EducationalStatus
                    };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }
    }
}