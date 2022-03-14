using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IEmployeeLanguageService
    {
        IDataResult<List<EmployeeLanguage>> GetAll();
        IDataResult<EmployeeLanguage> Get(int id);
        IResult Add(EmployeeLanguage employeeLanguage);
        IResult Delete(EmployeeLanguage employeeLanguage);
        IResult Update(EmployeeLanguage employeeLanguage);

    }
}