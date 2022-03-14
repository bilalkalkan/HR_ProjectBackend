using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IOperationClaimService
    {
        IDataResult<List<OperationClaim>> GetAll();
        IDataResult<OperationClaim> Get(int id);
        IResult Add(OperationClaim claim);
        IResult Delete(OperationClaim claim);
        IResult Update(OperationClaim claim);
    }
}
