using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract.Items
{
    public interface IDebitTypeService
    {
        IDataResult<List<DebitType>> GetAll();
        IDataResult<DebitType> Get(int id);
        IResult Add(DebitType debitType);
        IResult Delete(DebitType debitType);
        IResult Update(DebitType debitType);
    }
}