using System;

namespace ConsoleUI
{
   public  class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = CarManager();

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("DailyPrice: " + car.DailyPrice + "\n Model year :" + car.ModelYear + "\n");

            }
        }

        private static CarManager CarManager()
        {
            throw new NotImplementedException();
        }
    }

   
    }
}
