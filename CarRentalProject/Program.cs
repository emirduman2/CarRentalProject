using Business.Concrete;
using System;
using System.Collections.Generic;
using DataAccess.Concrete.Entity_Framework;
using Entities.Concrete;
using DataAccess.EntityFramework;
using DataAccess.Concrete.InMemory;
using System.Linq;
using Business.Constants;
using Core.Utilities.Results;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarDetails();


            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            rentalManager.Add(new Rental {CarId = 2, CustomerId = 2, RentalId = 2, RentDate = DateTime.Now, ReturnDate = null});

            foreach (var rentall in rentalManager.GetRentalDetailDtos().Data)
            {
                Console.WriteLine("Kiralama Numarası : " + rentall.RentalId + "\r\n" + " Kullanıcı Adı : " +  rentall.UserName + "\r\n" + " Müşteri Adı : " + rentall.CustomerName + "\r\n" +  " Marka Adı :  " + rentall.BrandName + "\r\n" +  " Kiralama Tarihi : " + rentall.RentDate + "\r\n" + " Kiralama Dönüş Tarihi : " +  rentall.ReturnDate);
            }
            
        }

        private static void CarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            var result = carManager.GetProductDetails();

            if (result.Success == true)
            {
                Console.WriteLine("****************ARABA LİSTESİ****************");
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + " / " + car.DailyPrice);
                    Console.WriteLine(
                        "---------------------------------------------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}