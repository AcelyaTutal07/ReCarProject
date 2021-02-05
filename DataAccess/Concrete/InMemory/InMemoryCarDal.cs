using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    class InMemoryCarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {

            new Car {Id = 1, ColorId = 1  BrandId = 5, DailyPrice = 30000, Description = "Otomatik Park", Model = 2010 };
            new Car {Id = 1, ColorId = 2, BrandId = 9, DailyPrice = 60000, Description = "Otomatik vites, Model = 2020 };
            new Car {Id = 3, ColorId = 3, BrandId = 8, DailyPrice = 80000, Description = "Otomatik Park", Model = 2015 };
            new Car {Id = 4, ColorId = 4, BrandId = 7, DailyPrice = 75000, Description = "Araba Anahtar", Model = 2019 };
            new Car {Id = 6, ColorId = 7, BrandId = 4, DailyPrice = 29000, Description = "Otomatik Park", Model = 2018 };


           
            {
            

        }
    }

    public void Add(Car car)
    {
        _cars.Add(car);
    }

    public void Delete(Car car)
    {
         //Linq-language Integrated query
        Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(carToDelete);
    }

    public List<Car> GetAll()
    {
        return _cars;
    }

    public List<Car> GetById(int id)
    {
        return _cars.Where(c => c.Id == ıd).ToList();
    }

    public void Update(Car car)
    {
        Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
        carToUpdate.BrandId = car.BrandId;
        carToUpdate.ColorId = car.ColorId;
        carToUpdate.DailyPrice = car.DailyPrice;
        carToUpdate.Description = car.Description;
        carToUpdate.ModelYear = car.ModelYear;


    }
}
}

    }
}
