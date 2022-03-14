using System.Collections.Generic;
using Business.Abstract.Items;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete.Items
{
    public class NationalityManager : INationalityService
    {
        private readonly INationalityDal _nationalityDal;

        public NationalityManager(INationalityDal nationalityDal)
        {
            _nationalityDal = nationalityDal;
        }

        public IDataResult<List<Nationality>> GetAll()
        {
            return new SuccessDataResult<List<Nationality>>(_nationalityDal.GetAll());
        }

        public IDataResult<Nationality> Get(int id)
        {
            return new SuccessDataResult<Nationality>(_nationalityDal.Get(e => e.Id == id));
        }


        public IResult Add(Nationality nationality)
        {
            _nationalityDal.Add(nationality);
            return new SuccessResult(Messages.ItemAdded);
        }


        public IResult Delete(Nationality nationality)
        {
            _nationalityDal.Delete(nationality);
            return new SuccessResult(Messages.ItemDeleted);
        }


        public IResult Update(Nationality nationality)
        {
            _nationalityDal.Update(nationality);
            return new SuccessResult(Messages.ItemUpdated);
        }
    }
}