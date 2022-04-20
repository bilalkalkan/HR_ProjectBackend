using Core.Entities;

namespace Entities.Concrete
{
    public class EducationaLevel : IEntity
    {
        public int Id { get; set; }
        public string EducationaLevelName { get; set; }
    }
}