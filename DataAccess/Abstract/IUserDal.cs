using System.Collections.Generic;
using Core.DataAccess;
using Core.Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IUserClaimDal:IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}