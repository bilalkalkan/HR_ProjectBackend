using Core.Entities;

namespace Entities.Concrete
{
    public class Nationality : IEntity
    {
        public int Id { get; set; }
        public string? NationalityName { get; set; }
    }
}