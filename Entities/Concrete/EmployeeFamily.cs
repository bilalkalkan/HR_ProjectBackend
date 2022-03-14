using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class EmployeeFamily : IEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string? Degree { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? IdentificationNumber { get; set; }
        public string? EducationalStatus { get; set; }
    }
}