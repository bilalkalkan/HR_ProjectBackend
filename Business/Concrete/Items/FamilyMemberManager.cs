using System.Collections.Generic;
using Business.Abstract.Items;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete.Items
{
    public class FamilyMemberManager : IFamilyMemberService
    {
        private readonly IFamilyMemberDal _familyMemberDal;

        public FamilyMemberManager(IFamilyMemberDal familyMemberDal)
        {
            _familyMemberDal = familyMemberDal;
        }

        public IDataResult<List<FamilyMember>> GetAll()
        {
            return new SuccessDataResult<List<FamilyMember>>(_familyMemberDal.GetAll());
        }

        public IDataResult<FamilyMember> Get(int id)
        {
            return new SuccessDataResult<FamilyMember>(_familyMemberDal.Get(e => e.Id == id));
        }


        public IResult Add(FamilyMember familyMember)
        {
            _familyMemberDal.Add(familyMember);
            return new SuccessResult(Messages.ItemAdded);
        }


        public IResult Delete(FamilyMember familyMember)
        {
            _familyMemberDal.Delete(familyMember);
            return new SuccessResult(Messages.ItemDeleted);
        }


        public IResult Update(FamilyMember familyMember)
        {
            _familyMemberDal.Update(familyMember);
            return new SuccessResult(Messages.ItemUpdated);
        }
    }
}