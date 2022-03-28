using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCountyDal:EfEntityRepositoryBase<County,HrContext>,ICountyDal
    {
        public List<CountyDto> GetCounties(Expression<Func<CountyDto, bool>> filter = null)
        {
            using (HrContext context=new HrContext())
            {
                var result = from county in context.Counties
                    join city in context.Cities on county.Id equals city.Id
                    select new CountyDto()
                    {
                        Id = county.Id,
                        CityId = city.Id,
                        CountyName = county.CountyName
                    };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
