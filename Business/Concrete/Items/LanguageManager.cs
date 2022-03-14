using System.Collections.Generic;
using Business.Abstract.Items;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete.Items
{
    public class LanguageManager : ILanguageService
    {
        private readonly ILanguageDal _languageDal;

        public LanguageManager(ILanguageDal languageDal)
        {
            _languageDal = languageDal;
        }

        public IDataResult<List<Language>> GetAll()
        {
            return new SuccessDataResult<List<Language>>(_languageDal.GetAll());
        }

        public IDataResult<Language> Get(int id)
        {
            return new SuccessDataResult<Language>(_languageDal.Get(e => e.Id == id));
        }


        public IResult Add(Language language)
        {
            _languageDal.Add(language);
            return new SuccessResult(Messages.ItemAdded);
        }


        public IResult Delete(Language language)
        {
            _languageDal.Delete(language);
            return new SuccessResult(Messages.ItemDeleted);
        }

        public IResult Update(Language language)
        {
            _languageDal.Update(language);
            return new SuccessResult(Messages.ItemUpdated);
        }
    }
}