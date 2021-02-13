using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (CarRentalProjectContext context = new CarRentalProjectContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Delete(Color entity)
        {
            using (CarRentalProjectContext context = new CarRentalProjectContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (CarRentalProjectContext context = new CarRentalProjectContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (CarRentalProjectContext context = new CarRentalProjectContext())
            {
                return filter == null ? context.Set<Color>().ToList() : context.Set<Color>().Where(filter).ToList();
            }
        }

        public void Update(Color entity)
        {
            using (CarRentalProjectContext context = new CarRentalProjectContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
