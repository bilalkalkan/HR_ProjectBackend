using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class OperationClaimManager:IOperationClaimService
    {
        private readonly IOperationClaimDal _operationClaimDal;

        public OperationClaimManager(IOperationClaimDal operationClaimDal)
        {
            _operationClaimDal = operationClaimDal;
        }

        public IDataResult<List<OperationClaim>> GetAll()
        {
            var result = _operationClaimDal.GetAll().Any();
            if (result==false)
            {
                return new ErrorDataResult<List<OperationClaim>>();
            }
            return new SuccessDataResult<List<OperationClaim>>(_operationClaimDal.GetAll());
        }

        public IDataResult<OperationClaim> Get(int id)
        {
            var result = _operationClaimDal.Get(o => o.Id == id);
            if (result==null)
            {
                return new ErrorDataResult<OperationClaim>();
            }
            return new SuccessDataResult<OperationClaim>(_operationClaimDal.Get(o => o.Id == id));
        }

        [SecuredOperation("admin")]
        public IResult Add(OperationClaim claim)
        {
            _operationClaimDal.Add(claim);
            return new SuccessResult(Messages.OperationClaimAdedd);
        }

        [SecuredOperation("admin")]

        public IResult Delete(OperationClaim claim)
        {
            _operationClaimDal.Delete(claim);
            return new SuccessResult(Messages.OperationClaimDeleted);
        }

        [SecuredOperation("admin")]
        public IResult Update(OperationClaim claim)
        {
            _operationClaimDal.Update(claim);
            return new SuccessResult(Messages.OperationClaimUpdated);
        }
    }
}
