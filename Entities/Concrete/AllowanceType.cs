using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class AllowanceType : IEntity
    {
        public int Id { get; set; }
        public string AllowanceTypeName { get; set; }
    }
}
