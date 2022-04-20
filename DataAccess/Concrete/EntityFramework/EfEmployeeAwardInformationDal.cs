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
    public class EfEmployeeAwardInformationDal:EfEntityRepositoryBase<EmployeeAwardInformation,HrContext>,IEmployeeAwardInformationDal
    {
        public List<EmployeeAwardInformationDto> GetEmployeeAwardInformationList(Expression<Func<EmployeeAwardInformationDto, bool>> filter = null)
        {
            using (HrContext context=new HrContext())
            {
                var result = from employeeAwardInformation in context.EmployeeAwardInformations
                    join employee in context.Employees on employeeAwardInformation.EmployeeId equals employee.Id
                    join typeOfAward in context.TypesOfAwards on employeeAwardInformation.AwardTypeId equals typeOfAward.Id 
                    select new EmployeeAwardInformationDto
                    {
                        Id = employeeAwardInformation.Id,
                        EmployeeId = employee.Id,
                        EmployeeFirstName = employee.FirstName,
                        EmployeeLastName = employee.LastName,
                        AwardDate = employeeAwardInformation.AwardDate,
                        AwardTypeId = employeeAwardInformation.AwardTypeId,
                        ReasonForAward = employeeAwardInformation.ReasonForAward,
                        CostOfThePrize = employeeAwardInformation.CostOfThePrize,
                        AwardDescription = employeeAwardInformation.AwardDescription,
                        AwardTypeName = typeOfAward.AwardName
                    };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
