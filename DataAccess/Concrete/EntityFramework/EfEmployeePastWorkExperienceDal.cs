using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEmployeePastWorkExperienceDal : EfEntityRepositoryBase<EmployeePastWorkExperience, HrContext>, IEmployeePastWorkExperienceDal
    {
        public List<EmployeePastWorkExperienceDto> GetEmployeePastWorkExperienceList(Expression<Func<EmployeePastWorkExperienceDto, bool>> filter = null)
        {
            using (HrContext context = new HrContext())
            {
                var result = from employeePastWorkExperience in context.EmployeePastWorkExperiences
                             join employee in context.Employees on employeePastWorkExperience.EmployeeId equals employee.Id
                             select new EmployeePastWorkExperienceDto
                             {
                                 Id = employeePastWorkExperience.Id,
                                 EmployeeId = employee.Id,
                                 EmployeeFirstName = employee.FirstName,
                                 EmployeeLastName = employee.LastName,
                                 CompanyInstitutionActive = employeePastWorkExperience.CompanyInstitutionActive,
                                 CompanyName = employeePastWorkExperience.CompanyName,
                                 Department = employeePastWorkExperience.Department,
                                 Duty = employeePastWorkExperience.Duty,
                                 EntryDate = employeePastWorkExperience.EntryDate,
                                 ReleaseDate = employeePastWorkExperience.ReleaseDate,
                                 ReasonForLeaving = employeePastWorkExperience.ReasonForLeaving,
                                 IncludeInSeniorityAccount = employeePastWorkExperience.IncludeInSeniorityAccount
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
