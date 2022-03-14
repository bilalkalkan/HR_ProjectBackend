using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract.Items
{
    public interface IFamilyMemberService
    {
        IDataResult<List<FamilyMember>> GetAll();
        IDataResult<FamilyMember> Get(int id);
        IResult Add(FamilyMember familyMember);
        IResult Delete(FamilyMember familyMember);
        IResult Update(FamilyMember familyMember);
    }
}