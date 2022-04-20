using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.DTOs
{
    public class EmployeePastWorkExperienceDto:IDto
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public bool CompanyInstitutionActive { get; set; }
        public string CompanyName { get; set; }
        public string Department { get; set; }
        public string Duty { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ReasonForLeaving { get; set; }
        public bool IncludeInSeniorityAccount { get; set; }
    }
}
