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
    public class EmployeeFamilyManager : IEmployeeFamilyService
    {


        private readonly IEmployeeFamilyDal _employeeFamilyDal;

        public EmployeeFamilyManager(IEmployeeFamilyDal employeeFamilyDal)
        {
            _employeeFamilyDal = employeeFamilyDal;
        }

        public IDataResult<List<EmployeeFamily>> GetAll()
        {
            return new SuccessDataResult<List<EmployeeFamily>>(_employeeFamilyDal.GetAll());
        }

        public IDataResult<List<EmployeeFamilyDto>> GetEmployeeFamilies()
        {
            return new SuccessDataResult<List<EmployeeFamilyDto>>(_employeeFamilyDal.GetEmployeeFamilies());
        }

        public IDataResult<EmployeeFamily> GetEmployeeFamily(int id)
        {
            return new SuccessDataResult<EmployeeFamily>(_employeeFamilyDal.Get(e => e.Id == id));
        }

        [SecuredOperation("user")]
        public IResult Add(EmployeeFamily employeeFamily)
        {
            _employeeFamilyDal.Add(employeeFamily);
            return new SuccessResult(Messages.EmployeeFamilyAdded);
        }

        [SecuredOperation("user")]
        public IResult Delete(EmployeeFamily employeeFamily)
        {
            _employeeFamilyDal.Delete(employeeFamily);
            return new SuccessResult(Messages.EmployeeFamilyDeleted);
        }

        [SecuredOperation("user")]
        public IResult Update(EmployeeFamily employeeFamily)
        {
            _employeeFamilyDal.Update(employeeFamily);
            return new SuccessResult(Messages.EmployeeFamilyUpdated);
        }
    }
}