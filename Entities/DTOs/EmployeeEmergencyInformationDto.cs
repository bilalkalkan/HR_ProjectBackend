using Core.Entities;

namespace Entities.DTOs
{
    public class EmployeeEmergencyInformationDto:IDto
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public int DegreeId { get; set; }
        public string DegreeName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int PriorityValue { get; set; }
    }
}
