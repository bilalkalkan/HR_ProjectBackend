using System.Collections.Generic;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class EmployeeDebitManager : IEmployeeDebitService
    {
        private readonly IEmployeeDebitDal _employeeDebitDal;

        public EmployeeDebitManager(IEmployeeDebitDal employeeDebitDal)
        {
            _employeeDebitDal = employeeDebitDal;
        }

        public IDataResult<List<EmployeeDebitDto>> GetEmployeeDebits()
        {
            return new SuccessDataResult<List<EmployeeDebitDto>>(_employeeDebitDal.GetEmployeeDebitList());
        }

        public IDataResult<EmployeeDebit> GetEmployeeDebit(int id)
        {
            return new SuccessDataResult<EmployeeDebit>(_employeeDebitDal.Get(e => e.Id == id));
        }

        [SecuredOperation("user")]
        public IResult Add(EmployeeDebit employeeDebit)
        {
            IResult result = BusinessRules.Run(DateControl(employeeDebit));
            if (result != null)
            {
                return result;
            }
            _employeeDebitDal.Add(employeeDebit);
            return new SuccessResult(Messages.EmployeeDebitAdded);
        }

        [SecuredOperation("user")]
        public IResult Delete(EmployeeDebit employeeDebit)
        {
           
            _employeeDebitDal.Delete(employeeDebit);
            return new SuccessResult(Messages.EmployeeDebitDeleted);
        }

        [SecuredOperation("user")]
        public IResult Update(EmployeeDebit employeeDebit)
        {

            IResult result = BusinessRules.Run(DateControl(employeeDebit));
            if (result != null)
            {
                return result;
            }
            _employeeDebitDal.Update(employeeDebit);
            return new SuccessResult(Messages.EmployeeDebitUpdated);
        }

        private IResult DateControl(EmployeeDebit employeeDebit)
        {
            if (employeeDebit.DebitDeliveryDate > employeeDebit.DebitReturnDate)
            {
                return new ErrorResult(Messages.DateError);
            }

            return new SuccessResult();
        }
    }
}
