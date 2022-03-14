using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract.Items;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete.Items
{
    public class AllowanceTypeManager : IAllowanceTypeService
    {
        private readonly IAllowanceTypeDal _allowanceTypeDal;

        public AllowanceTypeManager(IAllowanceTypeDal allowanceTypeDal)
        {
            _allowanceTypeDal = allowanceTypeDal;
        }

        public IDataResult<List<AllowanceType>> GetAll()
        {
            return new SuccessDataResult<List<AllowanceType>>(_allowanceTypeDal.GetAll());
        }

        public IDataResult<AllowanceType> Get(int id)
        {
            return new SuccessDataResult<AllowanceType>(_allowanceTypeDal.Get(e => e.Id == id));
        }

        public IResult Add(AllowanceType allowanceType)
        {
            _allowanceTypeDal.Add(allowanceType);
            return new SuccessResult(Messages.ItemAdded);
        }


        public IResult Delete(AllowanceType allowanceType)
        {
            _allowanceTypeDal.Delete(allowanceType);
            return new SuccessResult(Messages.ItemDeleted);
        }


        public IResult Update(AllowanceType allowanceType)
        {
            _allowanceTypeDal.Update(allowanceType);
            return new SuccessResult(Messages.ItemUpdated);
        }
    }
}
