using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract.Items
{
    public interface ILanguageService
    {
        IDataResult<List<Language>> GetAll();
        IDataResult<Language> Get(int id);
        IResult Add(Language language);
        IResult Delete(Language language);
        IResult Update(Language language);
    }
}