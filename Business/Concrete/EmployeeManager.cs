using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {

        private readonly IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public IDataResult<List<EmployeeDto>> GetEmployees()
        {
            return new SuccessDataResult<List<EmployeeDto>>(_employeeDal.GetEmployeeList());
        }

        public IDataResult<List<EmployeeDto>> GetAllByFilter(string gender, string nationalityName, string identificationNumber)
        {
            
            var result = _employeeDal.GetEmployeeList();

            if (gender != null)
            {
                result = result.Where(e => e.Gender == gender).ToList();
            }
            if (nationalityName != null)
            {
                result = result.Where(e => e.NationalityName == nationalityName).ToList();
            }
            if (identificationNumber != null)
            {
                result = result.Where(e => e.IdentificationNumber == identificationNumber).ToList();
            }
            return new SuccessDataResult<List<EmployeeDto>>(result);


        }

        public IDataResult<Employee> GetEmployee(int id)
        {
            return new SuccessDataResult<Employee>(_employeeDal.Get(e => e.Id == id));
        }


        [SecuredOperation("user")]
        public IResult Add(Employee employee)
        {

            _employeeDal.Add(employee);
            return new SuccessResult(Messages.EmployeeAdded);
        }

        [SecuredOperation("user")]
        public IResult Update(Employee employee)
        {
            _employeeDal.Update(employee);
            return new SuccessResult(Messages.EmployeeUpdated);
        }


        [SecuredOperation("user")]
        public IResult Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
            return new SuccessResult(Messages.EmployeeDeleted);
        }
    }
}