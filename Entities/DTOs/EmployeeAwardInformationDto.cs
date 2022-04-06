using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.DTOs
{
    public class EmployeeAwardInformationDto : IDto
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public DateTime AwardDate { get; set; }
        public string AwardType { get; set; }
        public string ReasonForAward { get; set; }
        public string CostOfThePrize { get; set; }
        public string AwardDescription { get; set; }
    }
}
