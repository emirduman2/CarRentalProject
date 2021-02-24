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
    public class EfUserDal : EfEntityRepositoryBase<User, CarRentalProjectContext>, IUserDal
    {
    }
}