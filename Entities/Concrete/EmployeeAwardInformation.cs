using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class EmployeeAwardInformation:IEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime AwardDate { get; set; }
        public int AwardTypeId { get; set; }
        public string ReasonForAward { get; set; }
        public string CostOfThePrize { get; set; }
        public string AwardDescription { get; set; }
    }
}
