using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class EmployeeContactInformation:IEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime ValidityStartSate { get; set; }
        public string Adress { get; set; }
        public int CityId { get; set; }
        public int CountyId { get; set; }
        public string CompanyPhoneNumber { get; set; }
        public string CompanyPhoneNumberShortCode { get; set; }
        public string OfficePhone { get; set; }
        public string ExtensionNumber { get; set; }
        public string CompanyEmail { get; set; }
        public bool AddToMailGroup { get; set; }
        public string LodgingCode { get; set; }
        public string PersonalPhoneNumber { get; set; }
        public string HomePhone { get; set; }
        public string PersonalEmail { get; set; }
        public string SystemUserName { get; set; }
        public string PostCode { get; set; }
    }
}
