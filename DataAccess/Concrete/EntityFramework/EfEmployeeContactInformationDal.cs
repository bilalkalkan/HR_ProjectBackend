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
    public class EfEmployeeContactInformationDal : EfEntityRepositoryBase<EmployeeContactInformation, HrContext>, IEmployeeContactInformationDal
    {
        public List<EmployeeContactInformationDto> GetEmployeeContactInformationList(Expression<Func<EmployeeContactInformationDto, bool>> filter = null)
        {
            using (HrContext context = new HrContext())
            {
                var result = from employeeContact in context.EmployeeContactInformations
                             join employee in context.Employees on employeeContact.EmployeeId equals employee.Id
                             join city in context.Cities on employeeContact.CityId equals city.Id
                             join county in context.Counties on employeeContact.CountyId equals county.Id
                             select new EmployeeContactInformationDto
                             {
                                 Id = employeeContact.Id,
                                 EmployeeId = employee.Id,
                                 EmployeeFirstName = employee.FirstName,
                                 EmployeeLastName = employee.LastName,
                                 ValidityStartSate = employeeContact.ValidityStartSate,
                                 Adress = employeeContact.Adress,
                                 CityId = city.Id,
                                 CityName = city.CityName,
                                 CountyId = county.Id,
                                 CountyName = county.CountyName,
                                 CompanyPhoneNumber = employeeContact.CompanyPhoneNumber,
                                 CompanyPhoneNumberShortCode = employeeContact.CompanyPhoneNumberShortCode,
                                 OfficePhone = employeeContact.OfficePhone,
                                 ExtensionNumber = employeeContact.ExtensionNumber,
                                 CompanyEmail = employeeContact.CompanyEmail,
                                 AddToMailGroup = employeeContact.AddToMailGroup,
                                 LodgingCode = employeeContact.LodgingCode,
                                 PersonalPhoneNumber = employeeContact.PersonalPhoneNumber,
                                 HomePhone = employeeContact.HomePhone,
                                 PersonalEmail = employeeContact.PersonalEmail,
                                 SystemUserName = employeeContact.SystemUserName,
                                 PostCode = employeeContact.PostCode
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
