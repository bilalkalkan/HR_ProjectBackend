using System.Collections.Generic;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class EmployeeLanguageManager : IEmployeeLanguageService
    {
        private readonly IEmployeeLanguageDal _employeeLanguageDal;

        public EmployeeLanguageManager(IEmployeeLanguageDal employeeLanguageDal)
        {
            _employeeLanguageDal = employeeLanguageDal;
        }

        public IDataResult<List<EmployeeLanguageDto>> GetEmployeeLanguages()
        {
            return new SuccessDataResult<List<EmployeeLanguageDto>>(_employeeLanguageDal.GetEmployeeLanguagelist());
        }

        public IDataResult<EmployeeLanguage> GetEmployeeLanguage(int id)
        {
            return new SuccessDataResult<EmployeeLanguage>(_employeeLanguageDal.Get(e => e.Id == id));
        }

        [SecuredOperation("user")]
        public IResult Add(EmployeeLanguage employeeLanguage)
        {
            _employeeLanguageDal.Add(employeeLanguage);
            return new SuccessResult(Messages.EmployeeLanguageAdded);
        }

        [SecuredOperation("user")]
        public IResult Delete(EmployeeLanguage employeeLanguage)
        {
            _employeeLanguageDal.Delete(employeeLanguage);
            return new SuccessResult(Messages.EmployeeLanguageDeleted);
        }

        [SecuredOperation("user")]
        public IResult Update(EmployeeLanguage employeeLanguage)
        {
            _employeeLanguageDal.Update(employeeLanguage);
            return new SuccessResult(Messages.EmployeeLanguageUpdated);
        }
    }
}