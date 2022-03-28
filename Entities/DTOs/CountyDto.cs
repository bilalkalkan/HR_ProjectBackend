using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.DTOs
{
    public class CountyDto:IDto
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string CountyName { get; set; }
    }
}
