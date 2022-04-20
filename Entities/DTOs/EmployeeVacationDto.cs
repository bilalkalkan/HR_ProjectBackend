using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.DTOs
{
    public class EmployeeVacationDto:IDto
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public int AllowanceTypeNameId { get; set; }
        public string AllowanceTypeName { get; set; }
        public DateTime AllowanceStartingDate { get; set; }
        public DateTime AllowanceExpirationDate { get; set; }
        public int AllowanceNumberOfDays { get; set; }
        public string AddressToBeAllowed { get; set; }
        public string Statement { get; set; }
    }
}
