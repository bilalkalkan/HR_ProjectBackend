using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Abstract.Items;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class EmployeeContactInformationManager : IEmployeeContactInformationService
    {
        private readonly IEmployeeContactInformationDal _employeeContactInformationDal;

        public EmployeeContactInformationManager(IEmployeeContactInformationDal employeeContactInformationDal)
        {
            _employeeContactInformationDal = employeeContactInformationDal;

        }
        public IDataResult<List<EmployeeContactInformation>> GetEmployeeContactInformations()
        {
            return new SuccessDataResult<List<EmployeeContactInformation>>(_employeeContactInformationDal.GetAll());
        }

        public IDataResult<EmployeeContactInformation> GetEmployeeContactInformation(int id)
        {
            return new SuccessDataResult<EmployeeContactInformation>(
                _employeeContactInformationDal.Get(e => e.Id == id));
        }

        [SecuredOperation("user")]
        public IResult Add(EmployeeContactInformation employeeContactInformation)
        {
            _employeeContactInformationDal.Add(employeeContactInformation);
            return new SuccessResult(Messages.EmployeeContactInformationAdded);
        }

        [SecuredOperation("user")]
        public IResult Delete(EmployeeContactInformation employeeContactInformation)
        {
            _employeeContactInformationDal.Delete(employeeContactInformation);
            return new SuccessResult(Messages.EmployeeContactInformationDeleted);
        }

        [SecuredOperation("user")]
        public IResult Update(EmployeeContactInformation employeeContactInformation)
        {
            _employeeContactInformationDal.Update(employeeContactInformation);
            return new SuccessResult(Messages.EmployeeContactInformationUpdated);
        }
    }
}
