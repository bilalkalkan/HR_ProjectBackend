using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class EmployeeAwardInformationManager:IEmployeeAwardInformationService
    {
        private readonly IEmployeeAwardInformationDal _employeeAwardInformationDal;

        public EmployeeAwardInformationManager(IEmployeeAwardInformationDal employeeAwardInformationDal)
        {
            _employeeAwardInformationDal = employeeAwardInformationDal;
        }

        public IDataResult<List<EmployeeAwardInformation>> GetEmployeeAwardInformations()
        {
            return new SuccessDataResult<List<EmployeeAwardInformation>>(_employeeAwardInformationDal.GetAll());
        }

        public IDataResult<EmployeeAwardInformation> GetEmployeeAwardInformation(int id)
        {
            return new SuccessDataResult<EmployeeAwardInformation>(_employeeAwardInformationDal.Get(e => e.Id == id));
        }

        public IResult Add(EmployeeAwardInformation employeeAwardInformation)
        {
            _employeeAwardInformationDal.Add(employeeAwardInformation);
            return new SuccessResult(Messages.EmployeeAwardInformationAdded);
        }

        public IResult Update(EmployeeAwardInformation employeeAwardInformation)
        {
            _employeeAwardInformationDal.Update(employeeAwardInformation);
            return new SuccessResult(Messages.EmployeeAwardInformationUpdated);
        }

        public IResult Delete(EmployeeAwardInformation employeeAwardInformation)
        {
            _employeeAwardInformationDal.Delete(employeeAwardInformation);
            return new SuccessResult(Messages.EmployeeAwardInformationDeleted);
        }
    }
}
