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
    public class EfEmployeeEducationDal : EfEntityRepositoryBase<EmployeeEducation, HrContext>, IEmployeeEducationDal
    {
        public List<EmployeeEducationDto> GetEmployeeEducationList(Expression<Func<EmployeeEducationDto, bool>> filter = null)
        {
            using (HrContext context = new HrContext())
            {
                var result = from employeeEducation in context.EmployeeEducations
                             join employee in context.Employees on employeeEducation.EmployeeId equals employee.Id
                             join educationaLevel in context.EducationaLevels on employeeEducation.EducationalLevelId equals educationaLevel.Id 
                             select new EmployeeEducationDto
                             {
                                 Id = employeeEducation.Id,
                                 EmployeeId = employee.Id,
                                 EmployeeFirstName = employee.FirstName,
                                 EmployeeLastName = employee.LastName,
                                 EducationalLevelName = educationaLevel.EducationaLevelName,
                                 SchoolYearOfStart = employeeEducation.SchoolYearOfStart,
                                 SchoolYearOfFinished = employeeEducation.SchoolYearOfFinished,
                                 DiplomaGrade = employeeEducation.DiplomaGrade,
                                 TractateName = employeeEducation.TractateName
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}