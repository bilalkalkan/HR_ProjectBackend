using Core.Entities;

namespace Entities.Concrete
{
    public class EmployeeLanguage : IEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ForeignLanguageId { get; set; }
        public string Reading { get; set; }
        public string Writing { get; set; }
        public string Talking { get; set; }
    }
}