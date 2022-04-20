using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IEmployeePastWorkExperienceService
    {
        IDataResult<List<EmployeePastWorkExperienceDto>> GetEmployeePastWorkExperiences();
        IDataResult<EmployeePastWorkExperience> GetEmployeePastWorkExperience(int id);
        IResult Add(EmployeePastWorkExperience employeePastWorkExperience);
        IResult Delete(EmployeePastWorkExperience employeePastWorkExperience);
        IResult Update(EmployeePastWorkExperience employeePastWorkExperience);
    }
}
