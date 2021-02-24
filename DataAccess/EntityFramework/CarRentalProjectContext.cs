﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EntityFramework
{
    public class CarRentalProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocaldb; Database = RentACar; Trusted_Connection = True");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        
        public DbSet<User> Users { get; set; }
        
        public DbSet<Rental> Rentals { get; set; }
        
        public DbSet<Customer> Customers { get; set; }
    }
}
