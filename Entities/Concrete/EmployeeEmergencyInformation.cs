using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class EmployeeEmergencyInformation:IEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Degree { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int PriorityValue { get; set; }
    }
}
