using Core.Entities;

namespace Entities.DTOs
{
    public class EmployeeEducationDto : IDto
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EducationalLevelName { get; set; }
        public int SchoolYearOfStart { get; set; }
        public int SchoolYearOfFinished { get; set; }
        public decimal DiplomaGrade { get; set; }
        public string TractateName { get; set; }
    }
}
