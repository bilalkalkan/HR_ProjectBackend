using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, HrContext>, IUserDal
    {


        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new HrContext())
            {
                var result = from operationClaim in context.OperationClaims
                    join userOperationClaim in context.UserOperationClaims
                        on operationClaim.Id equals userOperationClaim.OperationClaimId
                    where userOperationClaim.UserId == user.Id
                    select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }

        public List<UserOperationClaimDetailDto> GetUserDetail(Expression<Func<UserOperationClaimDetailDto, bool>> filter = null)
        {
            using (var context =new HrContext())
            {
                var result = from user in context.Users
                    join operationClaim in context.OperationClaims on user.Id equals operationClaim.Id
                    join userOperationClaim in context.UserOperationClaims on user.Id equals userOperationClaim.Id
                    select new UserOperationClaimDetailDto()
                    {
                        UserId = user.Id,
                        UserFirstName = user.FirstName,
                        UserLastName = user.LastName,
                        OperationClaimName = operationClaim.Name,
                        OperationClaimId = operationClaim.Id,
                        UserOperationClaimId = userOperationClaim.Id
                    };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}