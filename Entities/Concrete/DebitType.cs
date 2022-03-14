using Core.Entities;

namespace Entities.Concrete
{
    public class DebitType : IEntity
    {
        public int Id { get; set; }
        public string? DebitTypeName { get; set; }
    }
}