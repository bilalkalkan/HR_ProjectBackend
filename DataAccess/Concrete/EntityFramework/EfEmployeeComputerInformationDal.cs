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
    public class EfEmployeeComputerInformationDal : EfEntityRepositoryBase<EmployeeComputerInformation, HrContext>, IEmployeeComputerInformationDal
    {
        public List<EmployeeComputerInformationDto> GetEmployeeComputerInformationList(Expression<Func<EmployeeComputerInformationDto, bool>> filter = null)
        {
            using (HrContext context = new HrContext())
            {
                var result = from employeeComputerInformation in context.EmployeeComputerInformations
                             join employee in context.Employees on employeeComputerInformation.EmployeeId equals employee.Id
                             select new EmployeeComputerInformationDto
                             {
                                 Id = employeeComputerInformation.Id,
                                 EmployeeId = employee.Id,
                                 EmployeeFirstName = employee.FirstName,
                                 EmployeeLastName = employee.LastName,
                                 ValidityStartSate = employeeComputerInformation.ValidityStartSate,
                                 KnowledgeName = employeeComputerInformation.KnowledgeName,
                                 KnowledgeLevel = employeeComputerInformation.KnowledgeLevel
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
