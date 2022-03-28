using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract.Items
{
    public interface ICountyService
    {
        IDataResult<List<County>> GetCounties();
        IDataResult<List<County>> GetCountiesByCityId(int id);
    }
}
