using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class EmployeePastWorkExperienceManager : IEmployeePastWorkExperienceService
    {
        private readonly IEmployeePastWorkExperienceDal _employeePastWorkExperienceDal;

        public EmployeePastWorkExperienceManager(IEmployeePastWorkExperienceDal employeePastWorkExperienceDal)
        {
            _employeePastWorkExperienceDal = employeePastWorkExperienceDal;
        }

        public IDataResult<List<EmployeePastWorkExperience>> GetEmployeePastWorkExperiences()
        {
            return new SuccessDataResult<List<EmployeePastWorkExperience>>(_employeePastWorkExperienceDal.GetAll());
        }

        public IDataResult<EmployeePastWorkExperience> GetEmployeePastWorkExperience(int id)
        {
            return new SuccessDataResult<EmployeePastWorkExperience>(
                _employeePastWorkExperienceDal.Get(e => e.Id == id));
        }

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

        public IResult Delete(EmployeePastWorkExperience employeePastWorkExperience)
        {
            _employeePastWorkExperienceDal.Delete(employeePastWorkExperience);
            return new SuccessResult(Messages.EmployeePastWorkExperienceDeleted);

        }

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
