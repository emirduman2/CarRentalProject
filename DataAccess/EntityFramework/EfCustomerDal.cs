using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CarRentalProjectContext>, ICustomerDal
    {
    }
}