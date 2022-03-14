using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract.Items
{
    public interface INationalityService
    {
        IDataResult<List<Nationality>> GetAll();
        IDataResult<Nationality> Get(int id);
        IResult Add(Nationality nationality);
        IResult Delete(Nationality nationality);
        IResult Update(Nationality nationality);
    }
}