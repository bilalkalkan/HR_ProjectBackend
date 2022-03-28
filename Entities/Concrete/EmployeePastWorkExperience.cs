using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class EmployeePastWorkExperience:IEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
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
