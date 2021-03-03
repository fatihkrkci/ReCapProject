using Business.Concrete;
using Core.Entities.Concrete;
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
            //CarTest();
            //BrandTest();
            //ColorTest();
            //CustomerTest();
            //UserTest();
            RentalTest();
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental { CarId = 1 , CustomerId = 2 ,RentDate = new DateTime(2021, 02, 25), ReturnDate = new DateTime(2021, 02, 27) });
            //rentalManager.Update(new Rental { RentalId = 2, CarId = 1, CustomerId = 1, RentDate = new DateTime(2021, 02, 15), ReturnDate = new DateTime(2021, 02, 20) });

            var result = rentalManager.GetRentalDetails();
            if (result.Success)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.RentalId + ") " + rental.User + " => " + rental.ColorName + rental.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            userManager.Add(new User { FirstName = "Emir Safa", LastName = "Yavuz", Email = "emirsafayavuz@gmail.com"});

            var result = userManager.GetAll();
            if (result.Success)
            {
                foreach (var user in result.Data)
                {
                    Console.WriteLine(user.Id + " / " + user.FirstName + user.LastName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            customerManager.Add(new Customer { UserId = 2, CompanyName = "Yavuz Holding" });

            var result = customerManager.GetAll();
            if (result.Success)
            {
                foreach (var customer in result.Data)
                {
                    Console.WriteLine(customer.CompanyName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //colorManager.Add(new Color { ColorName = "YELLOV" });
            //colorManager.Update(new Color { ColorId = 7, ColorName = "YELLOW" });
            //colorManager.Delete(new Color { ColorId = 7 });

            var result = colorManager.GetAll();
            if (result.Success)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //brandManager.Add(new Brand { BrandName = "BMV" });
            //brandManager.Update(new Brand { BrandId = 6, BrandName = "BMW" });
            //brandManager.Delete(new Brand { BrandId = 6 });

            var result = brandManager.GetAll();
            if (result.Success)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //carManager.Add(new Car { BrandId = 1, ColorId = 2, ModelYear = "2021", DailyPrice = 275, Description = "Deneme Eklemesi" });
            //carManager.Update(new Car { CarId = 1006, BrandId = 2, ColorId = 1, ModelYear = "2019", DailyPrice = 200, Description = "Deneme Eklemesi - 2" });
            //carManager.Delete(new Car { CarId = 1006 });

            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId + " / " + car.BrandName + " / " + car.ColorName + " / " + car.Description + " / " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
