using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class EmployeeVacation : IEntity
    {

        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string? AllowanceType { get; set; }
        public DateTime AllowanceStartingDate { get; set; }
        public DateTime AllowanceExpirationDate { get; set; }
        public int AllowanceNumberOfDays { get; set; }
        public string? AddressToBeAllowed { get; set; }
        public string? Statement { get; set; }


    }
}