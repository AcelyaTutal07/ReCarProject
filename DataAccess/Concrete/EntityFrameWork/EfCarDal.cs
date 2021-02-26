using Core.DataAccess.EntitiyFramework;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFrameWork

{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCarDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}


       

