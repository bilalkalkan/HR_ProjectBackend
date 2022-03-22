using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    
   public class EmployeeComputerInformation:IEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime ValidityStartSate { get; set; }
        public string KnowledgeName { get; set; }
        public string KnowledgeLevel { get; set; }
    }
}
