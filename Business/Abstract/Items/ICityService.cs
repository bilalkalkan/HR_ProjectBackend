using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract.Items
{
    public interface ICityService
    {
        IDataResult<List<City>> GetCities();
    }
}
