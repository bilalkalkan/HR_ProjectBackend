using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract.Items
{
    public interface IAllowanceTypeService
    {
        IDataResult<List<AllowanceType>> GetAll();
        IDataResult<AllowanceType> Get(int id);
        IResult Add(AllowanceType allowanceType);
        IResult Delete(AllowanceType allowanceType);
        IResult Update(AllowanceType allowanceType);
    }
}
