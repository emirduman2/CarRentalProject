using System.Collections.Generic;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetUserByUserId(int userId);
        IDataResult<List<User>> GetUserByUserName(string userName);

        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}