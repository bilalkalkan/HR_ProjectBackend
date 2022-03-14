using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class EmployeeFamilyManager : IEmployeeFamilyService
    {


        private readonly IEmployeeFamilyDal _employeeFamilyDal;

        public EmployeeFamilyManager(IEmployeeFamilyDal employeeFamilyDal)
        {
            _employeeFamilyDal = employeeFamilyDal;
        }

        public IDataResult<List<EmployeeFamily>> GetEmployeeFamilies()
        {
            return new SuccessDataResult<List<EmployeeFamily>>(_employeeFamilyDal.GetAll());
        }

        public IDataResult<EmployeeFamily> GetEmployeeFamily(int id)
        {
            return new SuccessDataResult<EmployeeFamily>(_employeeFamilyDal.Get(e => e.Id == id));
        }


        public IResult Add(EmployeeFamily employeeFamily)
        {
            _employeeFamilyDal.Add(employeeFamily);
            return new SuccessResult(Messages.EmployeeFamilyAdded);
        }

        public IResult Delete(EmployeeFamily employeeFamily)
        {
            _employeeFamilyDal.Delete(employeeFamily);
            return new SuccessResult(Messages.EmployeeFamilyDeleted);
        }

        public IResult Update(EmployeeFamily employeeFamily)
        {
            _employeeFamilyDal.Update(employeeFamily);
            return new SuccessResult(Messages.EmployeeFamilyUpdated);
        }
    }
}