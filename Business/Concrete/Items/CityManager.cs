using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract.Items;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete.Items
{
    public class CityManager:ICityService
    {
        private readonly ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public IDataResult<List<City>> GetCities()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll());
        }
    }
}
