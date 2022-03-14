using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDebitTypeDal : EfEntityRepositoryBase<DebitType, HrContext>, IDebitTypeDal
    {
    }
}