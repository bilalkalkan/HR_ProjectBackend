using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract.Items
{
    public interface IEducationaLevelService
    {
        IDataResult<List<EducationaLevel>> GetAll();
        IDataResult<EducationaLevel> Get(int id);
        IResult Add(EducationaLevel educationalLevel);
        IResult Delete(EducationaLevel educationalLevel);
        IResult Update(EducationaLevel educationalLevel);
    }
}