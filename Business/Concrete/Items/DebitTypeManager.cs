using System.Collections.Generic;
using Business.Abstract.Items;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete.Items
{
    public class DebitTypeManager : IDebitTypeService
    {
        private readonly IDebitTypeDal _debitTypeDal;

        public DebitTypeManager(IDebitTypeDal debitTypeDal)
        {
            _debitTypeDal = debitTypeDal;
        }

        public IDataResult<List<DebitType>> GetAll()
        {
            return new SuccessDataResult<List<DebitType>>(_debitTypeDal.GetAll());
        }

        public IDataResult<DebitType> Get(int id)
        {
            return new SuccessDataResult<DebitType>(_debitTypeDal.Get(e => e.Id == id));
        }

        public IResult Add(DebitType debitType)
        {
            _debitTypeDal.Add(debitType);
            return new SuccessResult(Messages.ItemAdded);
        }


        public IResult Delete(DebitType debitType)
        {
            _debitTypeDal.Delete(debitType);
            return new SuccessResult(Messages.ItemDeleted);
        }


        public IResult Update(DebitType debitType)
        {
            _debitTypeDal.Update(debitType);
            return new SuccessResult(Messages.ItemUpdated);
        }
    }
}