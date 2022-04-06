﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IEmployeeAwardInformationDal:IEntityRepository<EmployeeAwardInformation>
    {
        List<EmployeeAwardInformationDto> GetEmployeeAwardInformationList(Expression<Func<EmployeeAwardInformationDto,bool>>filter=null);
    }
}
