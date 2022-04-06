using System;
using Core.Entities;

namespace Entities.DTOs
{
    public class EmployeeComputerInformationDto : IDto
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public DateTime ValidityStartSate { get; set; }
        public string KnowledgeName { get; set; }
        public string KnowledgeLevel { get; set; }
    }
}
