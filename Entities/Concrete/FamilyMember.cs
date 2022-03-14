using Core.Entities;

namespace Entities.Concrete
{
    public class FamilyMember : IEntity
    {
        public int Id { get; set; }
        public string? Member { get; set; }
    }
}