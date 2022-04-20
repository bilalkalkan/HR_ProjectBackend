using Core.Entities;

namespace Entities.Concrete
{
    public class Language : IEntity
    {
        public int Id { get; set; }
        public string NameOfLanguage { get; set; }
    }
}