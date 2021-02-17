using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Başarıyla arabanızı eklediniz.");                
            }
            else
            {
                Console.WriteLine("Lütfen arabanın ismini 2 karakterden uzun yapınız.");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);

            Console.WriteLine("Araba başarıyla silindi.");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _carDal.Get(c => c.CarId == id);
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(p => p.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(p=> p.ColorId == colorId);
        }

        public List<CarDetailDto> GetProductDetails()
        {
            return _carDal.GetProductDetails();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("Araba başarıyla güncellendi.");
        }
    }
}
