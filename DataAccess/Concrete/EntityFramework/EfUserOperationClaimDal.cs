using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserOperationClaimDal : EfEntityRepositoryBase<UserOperationClaim, HrContext>, IUserOperationClaimDal
    {
        public List<UserOperationClaimDetailDto> GetUserOperationClaimDetails(Expression<Func<UserOperationClaimDetailDto, bool>> filter = null)
        {
            using (HrContext context = new HrContext())
            {
                var result = from userOperationClaim in context.UserOperationClaims
                             join operationClaim in context.OperationClaims on userOperationClaim.Id equals operationClaim.Id
                             join user in context.Users on userOperationClaim.Id equals user.Id

                             select new UserOperationClaimDetailDto()
                             {
                                 UserOperationClaimId = userOperationClaim.Id,
                                 UserId = user.Id,
                                 UserFirstName = user.FirstName,
                                 UserLastName = user.LastName,
                                 OperationClaimId = operationClaim.Id,
                                 OperationClaimName = operationClaim.Name
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }

        }
    }
}
