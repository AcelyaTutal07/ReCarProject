using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BrandTest();

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }

            CarTest();

            private static void CarTest()
            {
                CarManager carManager = new CarManager(new EfCarDal());
            }
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Marka , renk , fiyat , özellik ");
                Console.WriteLine(car.Description);
                Console.WriteLine(car.BrandName + " " + car.ColorName + " " + car.DailyPrice + " " + car.Description);
            }
            var result = carManager.GetCarsDetails()  {

            }

            if (result.Succes == true)
            {
                foreach (var car in result.Data)
                {

                }
                ColorTest();
                private static void ColorTest()
                {
                    ColorManager colorManager = new ColorManager(new EfColorDal());
                    foreach (var color in colorManager.GetAll())
                    {
                        Console.WriteLine(color.ColorName);
                    }
                    {

                    }
                }

            }
        }
    }
}

            
        
    

