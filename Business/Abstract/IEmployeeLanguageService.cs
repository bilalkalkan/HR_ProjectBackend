using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IEmployeeLanguageService
    {
        IDataResult<List<EmployeeLanguage>> GetEmployeeLanguages();
        IDataResult<EmployeeLanguage> GetEmployeeLanguage(int id);
        IResult Add(EmployeeLanguage employeeLanguage);
        IResult Delete(EmployeeLanguage employeeLanguage);
        IResult Update(EmployeeLanguage employeeLanguage);

    }
}