using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class EmployeeLanguageManager : IEmployeeLanguageService
    {
        private IEmployeeLanguageDal _employeeLanguageDal;

        public EmployeeLanguageManager(IEmployeeLanguageDal employeeLanguageDal)
        {
            _employeeLanguageDal = employeeLanguageDal;
        }

        public IDataResult<List<EmployeeLanguage>> GetAll()
        {
            return new SuccessDataResult<List<EmployeeLanguage>>(_employeeLanguageDal.GetAll());
        }

        public IDataResult<EmployeeLanguage> Get(int id)
        {
            return new SuccessDataResult<EmployeeLanguage>(_employeeLanguageDal.Get(e => e.Id == id));
        }


        public IResult Add(EmployeeLanguage employeeLanguage)
        {
            _employeeLanguageDal.Add(employeeLanguage);
            return new SuccessResult(Messages.EmployeeLanguageAdded);
        }


        public IResult Delete(EmployeeLanguage employeeLanguage)
        {
            _employeeLanguageDal.Delete(employeeLanguage);
            return new SuccessResult(Messages.EmployeeLanguageDeleted);
        }

        public IResult Update(EmployeeLanguage employeeLanguage)
        {
            _employeeLanguageDal.Update(employeeLanguage);
            return new SuccessResult(Messages.EmployeeLanguageUpdated);
        }
    }
}