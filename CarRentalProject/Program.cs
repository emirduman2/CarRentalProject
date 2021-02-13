using Business.Concrete;
using System;
using DataAccess.Concrete.Entity_Framework;
using Entities.Concrete;
using DataAccess.EntityFramework;
using DataAccess.Concrete.InMemory;

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
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("\r\n" + "Araba İsmi = " + " " + car.CarName + "\r\n" + "Araba Numarası = " + " " + car.CarId + "\r\n" + "Marka Numarası = " + " " + car.BrandId + "\r\n" + "Renk Numarası = " + " " + car.ColorId + "\r\n" + "Model Yılı = " + " " + car.ModelYear + "\r\n" + "Arabanın Açıklaması = " + " " + car.Description);
                Console.WriteLine("---------------------------------------------------------------------------------------");
            }
        }
    }
}