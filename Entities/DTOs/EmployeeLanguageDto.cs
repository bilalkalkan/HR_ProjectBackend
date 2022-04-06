using Core.Entities;

namespace Entities.DTOs
{
    public class EmployeeLanguageDto:IDto
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string ForeignLanguage { get; set; }
        public string Reading { get; set; }
        public string Writing { get; set; }
        public string Talking { get; set; }
    }
}
