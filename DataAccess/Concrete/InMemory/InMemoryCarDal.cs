using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal(List<Car> car)
        {
            _car = car;

            _car = new List<Car>
            {
                new Car { CarId = 1, ColorId = 1, BrandId = 5, DailyPrice = 30000, Description = "Otomatik Park", ModelYear = 2010 },
                new Car { CarId = 1, ColorId = 2, BrandId = 9, DailyPrice = 60000, Description = "Otomatik vites", ModelYear = 2020 },
                new Car { CarId = 3, ColorId = 3, BrandId = 8, DailyPrice = 80000, Description = "Otomatik Park", ModelYear = 2015 },
                new Car { CarId = 4, ColorId = 4, BrandId = 7, DailyPrice = 75000, Description = "Araba Anahtar", ModelYear = 2019 },
                new Car { CarId = 6, ColorId = 7, BrandId = 4, DailyPrice = 29000, Description = "Otomatik Park", ModelYear = 2018 }
            };

        }

        public void Add(Car entity)
        {
            _car.Add(entity);

        }

        public void Delete(Car entity)
        {
         
            var result = _car.SingleOrDefault(c => c.CarId == entity.CarId); _car.Remove(result);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
        //çoğul istersek getall tekil olursa get diye tanımlıycaz.
        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _car;

        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}

    

    

       

     

    

       
       
