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
           //BrandTest
           //RentalTest
           //CustomerTest
           //UserTest
           //CarTest
           //ColorTest

        }

        ColorManager colorManager = new ColorManager(new EfColorDal());
       
        CarManager carManager = new CarManager(new EfCarDal());
        UserManager userManager = new UserManager(new EfUserDal());
        RentalManager rentalManager = new RentalManager(new EfRentalDal());
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());




        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Console.WriteLine("*****************Mevcut Markalarımız****************");
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine("Marka Id:{0}     Marka Adı:{1}", brand.BrandId, brand.BrandName);
            }

            Console.WriteLine("\n*****************Mevcut Markalarımız****************");
            brandManager.Add(new Brand { BrandName = "Mercedes" });
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine("Marka Id:{0}     Marka Adı:{1}", brand.BrandId, brand.BrandName);
            }
            Console.WriteLine("\n*****************Mevcut Markalarımız****************");
            brandManager.Update(new Brand { BrandId = 4, BrandName = "BMW" });
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine("Marka Id:{0}     Marka Adı:{1}", brand.BrandId, brand.BrandName);
            }

        }

       
            private static void CarTest(CarManager carManager)
            {

                Console.WriteLine("*****************Mevcut Arabalarımız****************");
                foreach (var car in carManager.GetAll().Data)
                {
                    Console.WriteLine("Araba Id: {0}   Marka Id:{1}   Renk Id:{2}   Model Yılı: {3}  Fiyatı: {4} TL   Açıklama: {5}"
                      , car.CarId, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
                }

                carManager.Add(new Car { BrandId = 2, ColorId = 3, ModelYear = 2003, DailyPrice = 60000, Description = "Güzel." });
                Console.WriteLine("*****************Mevcut Arabalarımız****************");
                foreach (var car in carManager.GetAll().Data)
                {
                    Console.WriteLine("Araba Id: {0}   Marka Id:{1}   Renk Id:{2}   Model Yılı: {3}  Fiyatı: {4} TL   Açıklama: {5}"
                      , car.CarId, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
                }

                carManager.Update(new Car { CarId = 5, BrandId = 3, ColorId = 3, ModelYear = 2007, DailyPrice = 60000, Description = "Güzel." });
                Console.WriteLine("*****************Mevcut Arabalarımız****************");
                foreach (var car in carManager.GetAll().Data)
                {
                    Console.WriteLine("Araba Id: {0}   Marka Id:{1}   Renk Id:{2}   Model Yılı: {3}  Fiyatı: {4} TL   Açıklama: {5}"
                      , car.CarId, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
                }

                carManager.Delete(new Car { CarId = 5, BrandId = 3, ColorId = 3, ModelYear = 2007, DailyPrice = 60000, Description = "Güzel." });
                Console.WriteLine("*****************Mevcut Arabalarımı****************");
                foreach (var car in carManager.GetAll().Data)
                {
                    Console.WriteLine("Araba Id: {0}   Marka Id:{1}   Renk Id:{2}   Model Yılı: {3}  Fiyatı: {4} TL   Açıklama: {5}"
                      , car.CarId, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
                }

                Console.WriteLine("\n-------------DailyPrice--------------");
                foreach (var car in carManager.GetByDailyPrice(50000, 130000).Data)
                {
                    Console.WriteLine("Araba Id: {0}   Marka Id:{1}   Renk Id:{2}   Model Yılı: {3}  Fiyatı: {4} TL   Açıklama: {5}"
                      , car.CarId, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
                }

              
                Console.WriteLine("-------------ColorId--------------");
                foreach (var car in carManager.GetCarsByColorId(4).Data)
                {
                    Console.WriteLine("Araba Id: {0}   Marka Id:{1}   Renk Id:{2}   Model Yılı: {3}  Fiyatı: {4} TL   Açıklama: {5}"
                      , car.CarId, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
                }

                Console.WriteLine("-------------CarDetail--------------");
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine("Araba Id: {0}   Marka Id:{1}   Renk Id:{2}   Model Yılı: {3}  Fiyatı: {4} TL   Açıklama: {5}"
                      , car.Descriptions, car.BrandName, car.ColorName, car.ModelYear, car.DailyPrice, car.Descriptions);
                }
            }

        private static void ColorTest(ColorManager colorManager)
        {
            Console.WriteLine("*****************Mevcut Renkler****************");
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine("Renk Id:{0}     Renk Adı:{1}", color.ColorId, color.ColorName);
            }

            Console.WriteLine("\n*****************Mevcut Renkler****************");
            colorManager.Add(new Color { ColorName = "Kırmızı" });
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine("Renk Id:{0}     Renk Adı:{1}", color.ColorId, color.ColorName);
            }

            Console.WriteLine("\n*****************Mevcut Renkler****************");
            colorManager.Update(new Color { ColorId = 5, ColorName = "Siyah" });
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine("Renk Id:{0}     Renk Adı:{1}", color.ColorId, color.ColorName);
            }

            Console.WriteLine("\n*****************Mevcut Renkler****************");
            colorManager.Delete(new Color { ColorId = 5, ColorName = "Gri" });
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine("Marka Id:{0}     Marka Adı:{1}", color.ColorId, color.ColorName);
            }

          
        }


    }
}
    

            
        
    

