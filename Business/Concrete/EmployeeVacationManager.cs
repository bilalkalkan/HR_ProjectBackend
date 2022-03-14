using System;
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
    public class EmployeeVacationManager : IEmployeeVacationService
    {
        private readonly IEmployeeVacationDal _employeeVacationDal;

        public EmployeeVacationManager(IEmployeeVacationDal employeeVacationDal)
        {
            _employeeVacationDal = employeeVacationDal;
        }

        public IDataResult<List<EmployeeVacation>> GetAll()
        {
            return new SuccessDataResult<List<EmployeeVacation>>(_employeeVacationDal.GetAll());
        }

        public IDataResult<EmployeeVacation> Get(int id)
        {
            return new SuccessDataResult<EmployeeVacation>(_employeeVacationDal.Get(e => e.Id == id));
        }


        [SecuredOperation("user")]
        public IResult Add(EmployeeVacation employeeVacation)
        {
            IResult result = BusinessRules.Run(DateControl(employeeVacation), CalculateDay(employeeVacation));

            if (result != null)
            {
                return result;
            }

            _employeeVacationDal.Add(employeeVacation);
            return new SuccessResult(Messages.EmployeeVacationAdded);
        }

        [SecuredOperation("user")]
        public IResult Delete(EmployeeVacation employeeVacation)
        {
            _employeeVacationDal.Delete(employeeVacation);
            return new SuccessResult(Messages.EmployeeVacationDeleted);
        }

        [SecuredOperation("user")]
        public IResult Update(EmployeeVacation employeeVacation)
        {
            IResult result = BusinessRules.Run(DateControl(employeeVacation), CalculateDay(employeeVacation));
            if (result != null)
            {
                return result;
            }


            _employeeVacationDal.Update(employeeVacation);
            return new SuccessResult(Messages.EmployeeVacationUpdated);
        }

        private IResult DateControl(EmployeeVacation employeeVacation)
        {
            if (employeeVacation.AllowanceStartingDate > employeeVacation.AllowanceExpirationDate)
            {
                return new ErrorResult(Messages.DateSelectionError);
            }

            return new SuccessResult();
        }

        private IResult CalculateDay(EmployeeVacation employeeVacation)
        {
            TimeSpan alloweDay = employeeVacation.AllowanceExpirationDate - employeeVacation.AllowanceStartingDate;
            var Days = alloweDay.TotalDays;
            employeeVacation.AllowanceNumberOfDays = (int)Days;
            return new SuccessResult();
        }
    }
}