using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class EmployeeDebit : IEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string? DebitType { get; set; }
        public DateTime DebitDeliveryDate { get; set; }
        public string? DebitReturnStatus { get; set; }
        public DateTime DebitReturnDate { get; set; }
        public string? DebitStatement { get; set; }
    }
}