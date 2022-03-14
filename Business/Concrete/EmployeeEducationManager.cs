﻿using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
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

        public IDataResult<List<EmployeeEducation>> GetAll()
        {
            return new SuccessDataResult<List<EmployeeEducation>>(_employeeEducationDal.GetAll());
        }

        public IDataResult<EmployeeEducation> Get(int id)
        {
            return new SuccessDataResult<EmployeeEducation>(_employeeEducationDal.Get(e => e.Id == id));
        }

        public IResult Add(EmployeeEducation employeeEducation)
        {
            _employeeEducationDal.Add(employeeEducation);
            return new SuccessResult(Messages.EmployeeEducationAdded);
        }

        public IResult Update(EmployeeEducation employeeEducation)
        {
            _employeeEducationDal.Update(employeeEducation);
            return new SuccessResult(Messages.EmployeeEducationUpdated);
        }

        public IResult Delete(EmployeeEducation employeeEducation)
        {
            _employeeEducationDal.Delete(employeeEducation);
            return new SuccessResult(Messages.EmployeeEducationDeleted);
        }
    }
}