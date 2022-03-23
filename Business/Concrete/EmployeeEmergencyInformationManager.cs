using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class EmployeeEmergencyInformationManager:IEmployeeEmergencyInformationService
    {
        private readonly IEmployeeEmergencyInformationDal _employeeEmergencyInformationDal;

        public EmployeeEmergencyInformationManager(IEmployeeEmergencyInformationDal employeeEmergencyInformationDal)
        {
            _employeeEmergencyInformationDal = employeeEmergencyInformationDal;
        }

        public IDataResult<List<EmployeeEmergencyInformation>> GetEmployeeEmergencyInformations()
        {
            return new SuccessDataResult<List<EmployeeEmergencyInformation>>(_employeeEmergencyInformationDal.GetAll());
        }

        public IDataResult<EmployeeEmergencyInformation> GetEmployeeEmergencyInformation(int id)
        {
            return new SuccessDataResult<EmployeeEmergencyInformation>(
                _employeeEmergencyInformationDal.Get(e => e.Id == id));
        }

        [SecuredOperation("user")]
        public IResult Add(EmployeeEmergencyInformation employeeEmergencyInformation)
        {
            _employeeEmergencyInformationDal.Add(employeeEmergencyInformation);
            return new SuccessResult(Messages.EmployeeEmergencyInformationAdded);
        }

        [SecuredOperation("user")]
        public IResult Delete(EmployeeEmergencyInformation employeeEmergencyInformation)
        {
            _employeeEmergencyInformationDal.Delete(employeeEmergencyInformation);
            return new SuccessResult(Messages.EmployeeEmergencyInformationDeleted);
        }

        [SecuredOperation("user")]
        public IResult Update(EmployeeEmergencyInformation employeeEmergencyInformation)
        {
            _employeeEmergencyInformationDal.Update(employeeEmergencyInformation);
            return new SuccessResult(Messages.EmployeeEmergencyInformationDeleted);
        }
    }
}
