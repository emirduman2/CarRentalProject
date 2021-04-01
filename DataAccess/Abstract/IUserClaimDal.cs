using System.Collections.Generic;
using Core.DataAccess;
using Core.Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IUserClaim:IEntityRepository<UserInformation>
    {
        List<OperationClaim> GetClaims(UserInformation user);
    }
}