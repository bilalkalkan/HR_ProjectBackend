using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.DTOs
{
    public class EmployeeDebitDto:IDto
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public int DebitTypeId { get; set; }
        public string DebitTypeName { get; set; }
        public DateTime DebitDeliveryDate { get; set; }
        public string DebitReturnStatus { get; set; }
        public DateTime DebitReturnDate { get; set; }
        public string DebitStatement { get; set; }
    }
}
