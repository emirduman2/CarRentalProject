using Business.Concrete;
using System;
using DataAccess.Concrete.Entity_Framework;
using Entities.Concrete;
using DataAccess.EntityFramework;
using DataAccess.Concrete.InMemory;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());


            Console.WriteLine("****************ARABA LİSTESİ****************");
            foreach (var car in carManager.GetProductDetails())
            {
                Console.WriteLine(car.CarName + " / " + car.DailyPrice);
                Console.WriteLine("---------------------------------------------------------------------------------------");
            }
        }
    }
}