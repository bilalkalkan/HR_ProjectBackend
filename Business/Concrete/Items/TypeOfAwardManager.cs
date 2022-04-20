using System;
using System.Collections.Generic;
using Business.Abstract.Items;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete.Items
{
    public class TypeOfAwardManager:ITypeOfAwardService
    {
        private readonly ITypeOfAwardDal _typeOfAwardDal;

        public TypeOfAwardManager(ITypeOfAwardDal typeOfAwardDal)
        {
            _typeOfAwardDal = typeOfAwardDal;
        }

        public IDataResult<List<TypeOfAward>> GetAll()
        {
            return new SuccessDataResult<List<TypeOfAward>>(_typeOfAwardDal.GetAll());
        }

        public IDataResult<TypeOfAward> GetById(int id)
        {
            return new SuccessDataResult<TypeOfAward>(_typeOfAwardDal.Get(e => e.Id == id));
        }

        public IResult Add(TypeOfAward typeOfAward)
        {
            _typeOfAwardDal.Add(typeOfAward);
            return new SuccessResult(Messages.ItemAdded);
        }

        public IResult Delete(TypeOfAward typeOfAward)
        {
            _typeOfAwardDal.Delete(typeOfAward);
            return new SuccessResult(Messages.ItemDeleted);
        }

        public IResult Update(TypeOfAward typeOfAward)
        {
            _typeOfAwardDal.Update(typeOfAward);
            return new SuccessResult(Messages.ItemUpdated);
        }
    }
}
