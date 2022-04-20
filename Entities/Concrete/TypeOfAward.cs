using Core.Entities;

namespace Entities.Concrete
{
    public class TypeOfAward:IEntity
    {
        public int Id { get; set; }
        public string AwardName { get; set; }
    }
}
