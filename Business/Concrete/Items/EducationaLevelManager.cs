using System.Collections.Generic;
using Business.Abstract.Items;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete.Items
{
    public class EducationaLevelManager : IEducationaLevelService
    {
        private readonly IEducationaLevelDal _educationaLevelDal;

        public EducationaLevelManager(IEducationaLevelDal educationaLevelDal)
        {
            _educationaLevelDal = educationaLevelDal;
        }

        public IDataResult<List<EducationaLevel>> GetAll()
        {
            return new SuccessDataResult<List<EducationaLevel>>(_educationaLevelDal.GetAll());
        }


        public IDataResult<EducationaLevel> Get(int id)
        {
            return new SuccessDataResult<EducationaLevel>(_educationaLevelDal.Get(e => e.Id == id));
        }



        public IResult Add(EducationaLevel educationaLevel)
        {
            _educationaLevelDal.Add(educationaLevel);
            return new SuccessResult(Messages.ItemAdded);
        }


        public IResult Delete(EducationaLevel educationaLevel)
        {
            _educationaLevelDal.Delete(educationaLevel);
            return new SuccessResult(Messages.ItemDeleted);
        }

        public IResult Update(EducationaLevel educationaLevel)
        {
            _educationaLevelDal.Update(educationaLevel);
            return new SuccessResult(Messages.ItemUpdated);
        }
    }
}