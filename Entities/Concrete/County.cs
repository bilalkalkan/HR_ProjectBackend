using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class County:IEntity
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string CountyName { get; set; }
    }
}
