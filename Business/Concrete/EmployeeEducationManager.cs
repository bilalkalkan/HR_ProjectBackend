using System.Collections.Generic;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class EmployeeEducationManager : IEmployeeEducationService
    {
        private readonly IEmployeeEducationDal _employeeEducationDal;

        public EmployeeEducationManager(IEmployeeEducationDal employeeEducationDal)
        {
            _employeeEducationDal = employeeEducationDal;
        }

        public IDataResult<List<EmployeeEducation>> GetEmployeeEducations()
        {
            return new SuccessDataResult<List<EmployeeEducation>>(_employeeEducationDal.GetAll());
        }

        public IDataResult<EmployeeEducation> GetEmployeeEducation(int id)
        {
            return new SuccessDataResult<EmployeeEducation>(_employeeEducationDal.Get(e => e.Id == id));
        }

        [SecuredOperation("user")]
        public IResult Add(EmployeeEducation employeeEducation)
        {
            IResult result = BusinessRules.Run(CheckDate(employeeEducation));
            if (result!=null)
            {
                return result;
            }
            _employeeEducationDal.Add(employeeEducation);
            return new SuccessResult(Messages.EmployeeEducationAdded);
        }

        [SecuredOperation("user")]
        public IResult Update(EmployeeEducation employeeEducation)
        {

            IResult result = BusinessRules.Run(CheckDate(employeeEducation));
            if (result != null)
            {
                return result;
            }
            _employeeEducationDal.Update(employeeEducation);
            return new SuccessResult(Messages.EmployeeEducationUpdated);
        }

        [SecuredOperation("user")]
        public IResult Delete(EmployeeEducation employeeEducation)
        {
         
            _employeeEducationDal.Delete(employeeEducation);
            return new SuccessResult(Messages.EmployeeEducationDeleted);
        }

        private IResult CheckDate(EmployeeEducation employeeEducation)
        {
            if (employeeEducation.SchoolYearOfStart>employeeEducation.SchoolYearOfFinished)
            {
                return new ErrorResult(Messages.DateSelectionError);
            }

            return new SuccessResult();
        }
    }
}