using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract.Items
{
    public interface ITypeOfAwardService
    {
        IDataResult<List<TypeOfAward>> GetAll();
        IDataResult<TypeOfAward> GetById(int id);
        IResult Add(TypeOfAward typeOfAward);
        IResult Delete(TypeOfAward typeOfAward);
        IResult Update(TypeOfAward typeOfAward);
    }
}
