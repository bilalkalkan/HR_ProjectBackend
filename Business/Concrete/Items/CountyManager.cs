using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract.Items;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete.Items
{
    public class CountyManager:ICountyService
    {
        private readonly ICountyDal _countyDal;

        public CountyManager(ICountyDal countyDal)
        {
            _countyDal = countyDal;
        }


        public IDataResult<List<County>> GetCounties()
        {
            return new SuccessDataResult<List<County>>(_countyDal.GetAll());
        }

        public IDataResult<List<County>> GetCountiesByCityId(int id)
        {
            return new SuccessDataResult<List<County>>(_countyDal.GetAll(e => e.CityId == id));
        }
    }
}
