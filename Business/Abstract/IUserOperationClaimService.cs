using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IUserOperationClaimService
    {
        IDataResult<List<UserOperationClaim>> GetAll();
        IDataResult<UserOperationClaim> Get(int id);
        IDataResult<List<UserOperationClaimDetailDto>> GetDetail();
        IResult Add(UserOperationClaim userOperationClaim);
        IResult Delete(UserOperationClaim userOperation);
        IResult Update(UserOperationClaim userOperationClaim);

    }
}
