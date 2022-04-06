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
    public class EmployeeAwardInformationManager:IEmployeeAwardInformationService
    {
        private readonly IEmployeeAwardInformationDal _employeeAwardInformationDal;

        public EmployeeAwardInformationManager(IEmployeeAwardInformationDal employeeAwardInformationDal)
        {
            _employeeAwardInformationDal = employeeAwardInformationDal;
        }

        public IDataResult<List<EmployeeAwardInformationDto>> GetEmployeeAwardInformations()
        {
            return new SuccessDataResult<List<EmployeeAwardInformationDto>>(_employeeAwardInformationDal.GetEmployeeAwardInformationList());
        }

        public IDataResult<EmployeeAwardInformation> GetEmployeeAwardInformation(int id)
        {
            return new SuccessDataResult<EmployeeAwardInformation>(_employeeAwardInformationDal.Get(e => e.Id == id));
        }

        [SecuredOperation("user")]
        public IResult Add(EmployeeAwardInformation employeeAwardInformation)
        {
            _employeeAwardInformationDal.Add(employeeAwardInformation);
            return new SuccessResult(Messages.EmployeeAwardInformationAdded);
        }

        [SecuredOperation("user")]
        public IResult Update(EmployeeAwardInformation employeeAwardInformation)
        {
            _employeeAwardInformationDal.Update(employeeAwardInformation);
            return new SuccessResult(Messages.EmployeeAwardInformationUpdated);
        }

        [SecuredOperation("user")]
        public IResult Delete(EmployeeAwardInformation employeeAwardInformation)
        {
            _employeeAwardInformationDal.Delete(employeeAwardInformation);
            return new SuccessResult(Messages.EmployeeAwardInformationDeleted);
        }
    }
}
