using Core.Entities;

namespace Entities.Concrete
{
    public class EmployeeEducation : IEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string? EducationalLevel { get; set; }
        public int SchoolYearOfStart { get; set; }
        public int SchoolYearOfFinished { get; set; }
        public decimal DiplomaGrade { get; set; }
        public string? TractateName { get; set; }

    }
}