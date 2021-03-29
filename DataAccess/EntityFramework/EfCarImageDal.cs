using System.IO;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.EntityFramework
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, CarRentalProjectContext>, ICarImageDal
    {
        public bool IsExist(int id)
        {
            using (CarRentalProjectContext context = new CarRentalProjectContext())
            {
                return context.CarImages.Any(p => p.ImageId == id);
            }

        }
    }
}