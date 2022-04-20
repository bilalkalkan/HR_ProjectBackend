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
    public class EfEmployeeEmergencyInformationDal : EfEntityRepositoryBase<EmployeeEmergencyInformation, HrContext>, IEmployeeEmergencyInformationDal
    {
        public List<EmployeeEmergencyInformationDto> GetEmployeeEmergencyInformationlist(Expression<Func<EmployeeEmergencyInformationDto, bool>> filter = null)
        {
            using (HrContext context = new HrContext())
            {
                var result = from employeeEmergencyInformation in context.EmployeeEmergencyInformations
                             join employee in context.Employees on employeeEmergencyInformation.EmployeeId equals employee.Id
                             join familyMember in context.FamilyMembers on employeeEmergencyInformation.DegreeId equals familyMember.Id 
                             select new EmployeeEmergencyInformationDto
                             {
                                 Id = employeeEmergencyInformation.Id,
                                 EmployeeId = employee.Id,
                                 EmployeeFirstName = employee.FirstName,
                                 EmployeeLastName = employee.LastName,
                                 DegreeName = familyMember.Member,
                                 FirstName = employeeEmergencyInformation.FirstName,
                                 LastName = employeeEmergencyInformation.LastName,
                                 PhoneNumber = employeeEmergencyInformation.PhoneNumber,
                                 PriorityValue = employeeEmergencyInformation.PriorityValue
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
