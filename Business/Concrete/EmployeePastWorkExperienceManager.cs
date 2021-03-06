using System.Collections.Generic;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class EmployeePastWorkExperienceManager : IEmployeePastWorkExperienceService
    {
        private readonly IEmployeePastWorkExperienceDal _employeePastWorkExperienceDal;

        public EmployeePastWorkExperienceManager(IEmployeePastWorkExperienceDal employeePastWorkExperienceDal)
        {
            _employeePastWorkExperienceDal = employeePastWorkExperienceDal;
        }

        public IDataResult<List<EmployeePastWorkExperienceDto>> GetEmployeePastWorkExperiences()
        {
            return new SuccessDataResult<List<EmployeePastWorkExperienceDto>>(_employeePastWorkExperienceDal.GetEmployeePastWorkExperienceList());
        }

        public IDataResult<EmployeePastWorkExperience> GetEmployeePastWorkExperience(int id)
        {
            return new SuccessDataResult<EmployeePastWorkExperience>(
                _employeePastWorkExperienceDal.Get(e => e.Id == id));
        }

        [SecuredOperation("user")]
        public IResult Add(EmployeePastWorkExperience employeePastWorkExperience)
        {
            IResult result = BusinessRules.Run(DateControl(employeePastWorkExperience));
            if (result != null)
            {
                return result;
            }
            _employeePastWorkExperienceDal.Add(employeePastWorkExperience);
            return new SuccessResult(Messages.EmployeePastWorkExperienceAdded);
        }

        [SecuredOperation("user")]
        public IResult Delete(EmployeePastWorkExperience employeePastWorkExperience)
        {
            _employeePastWorkExperienceDal.Delete(employeePastWorkExperience);
            return new SuccessResult(Messages.EmployeePastWorkExperienceDeleted);

        }

        [SecuredOperation("user")]
        public IResult Update(EmployeePastWorkExperience employeePastWorkExperience)
        {
            _employeePastWorkExperienceDal.Update(employeePastWorkExperience);
            return new SuccessResult(Messages.EmployeePastWorkExperienceUpdated);
        }

        private IResult DateControl(EmployeePastWorkExperience employeePastWorkExperience)
        {
            if (employeePastWorkExperience.EntryDate > employeePastWorkExperience.ReleaseDate)
            {
                return new ErrorResult(Messages.DateSelectionError);
            }

            return new SuccessResult();
        }
    }
}
