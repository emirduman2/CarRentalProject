using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalProjectContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarRentalProjectContext context = new CarRentalProjectContext())
            {
                var result = from rental in filter == null ? context.Rentals : context.Rentals.Where(filter)
                    join car in context.Cars
                        on rental.CarId equals car.CarId
                    join customer in context.Customers
                        on rental.CustomerId equals customer.CustomerId
                    join brand in context.Brands
                        on car.BrandId equals brand.BrandId
                    join user in context.Users
                        on customer.UserId equals user.Id
                    select new RentalDetailDto
                    {
                        RentalId = rental.RentalId,
                        BrandName = brand.BrandName,
                        CustomerName = customer.CompanyName,
                        UserName = user.FirstName + " " + user.LastName,
                        RentDate = rental.RentDate,
                        ReturnDate = (DateTime)rental.ReturnDate
                    };
                return result.ToList();
            }
        }
    }
}