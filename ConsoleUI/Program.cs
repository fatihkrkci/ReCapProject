using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            //BrandTest();
            //ColorTest();
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //colorManager.Add(new Color { ColorName = "YELLOV" });
            //colorManager.Update(new Color { ColorId = 7, ColorName = "YELLOW" });
            //colorManager.Delete(new Color { ColorId = 7 });

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //brandManager.Add(new Brand { BrandName = "BMV" });
            //brandManager.Update(new Brand { BrandId = 6, BrandName = "BMW" });
            //brandManager.Delete(new Brand { BrandId = 6 });

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //carManager.Add(new Car { BrandId = 1, ColorId = 2, ModelYear = "2021", DailyPrice = 275, Description = "Deneme Eklemesi" });
            //carManager.Update(new Car { CarId = 1006, BrandId = 2, ColorId = 1, ModelYear = "2019", DailyPrice = 200, Description = "Deneme Eklemesi - 2" });
            //carManager.Delete(new Car { CarId = 1006 });

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarId + " / " + car.BrandName + " / " + car.ColorName + " / " + car.Description + " / " + car.DailyPrice);
            }
        }
    }
}
