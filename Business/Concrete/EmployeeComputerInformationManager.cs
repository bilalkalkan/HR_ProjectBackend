using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class EmployeeComputerInformationManager : IEmployeeComputerInformationService
    {
        private readonly IEmployeeComputerInformationDal _employeeComputerInformationDal;

        public EmployeeComputerInformationManager(IEmployeeComputerInformationDal employeeComputerInformationDal)
        {
            _employeeComputerInformationDal = employeeComputerInformationDal;
        }

        public IDataResult<List<EmployeeComputerInformationDto>> GetEmployeeComputerInformations()
        {
            return new SuccessDataResult<List<EmployeeComputerInformationDto>>(_employeeComputerInformationDal.GetEmployeeComputerInformationList());
        }

        public IDataResult<EmployeeComputerInformation> GetEmployeeComputerInformation(int id)
        {
            return new SuccessDataResult<EmployeeComputerInformation>(
                _employeeComputerInformationDal.Get(e => e.Id == id));
        }

        [SecuredOperation("user")]
        public IResult Add(EmployeeComputerInformation employeeComputerInformation)
        {
            _employeeComputerInformationDal.Add(employeeComputerInformation);
            return new SuccessResult(Messages.EmployeeComputerInformationAdded);
        }

        [SecuredOperation("user")]
        public IResult Delete(EmployeeComputerInformation employeeComputerInformation)
        {
            _employeeComputerInformationDal.Delete(employeeComputerInformation);
            return new SuccessResult(Messages.EmployeeComputerInformationDeleted);
        }

        [SecuredOperation("user")]
        public IResult Update(EmployeeComputerInformation employeeComputerInformation)
        {
            _employeeComputerInformationDal.Update(employeeComputerInformation);
            return new SuccessResult(Messages.EmployeeComputerInformationUpdated);
        }
    }
}
