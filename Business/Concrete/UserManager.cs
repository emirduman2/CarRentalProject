using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IDataResult<List<User>> GetAll()
        {
            if (DateTime.Now.Hour == 24)
            {
                return new ErrorDataResult<List<User>>(Messages.MaintenanceTime);
            }
            else
            {
                return new SuccessDataResult<List<User>>(_userDal.GetAll());
            }
        }

        public IDataResult<User> GetUserByUserId(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(r=> r.Id == userId));
        }

        public IDataResult<List<User>> GetUserByUserName(string userName)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u=> u.FirstName + u.LastName == userName));
        }

        public IResult Add(User user)
        {
            if (user.FirstName.Length < 2 && user.LastName.Length < 2 && user.Password.Length < 6)
            {
                return new ErrorResult(Messages.AddFailed);
            }
            else
            {
                _userDal.Add(user);
                return new SuccessResult(Messages.UserAdded);
            }
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);

            return new SuccessResult(Messages.UserDeleted);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);

            return new SuccessResult(Messages.UserUpdated);
        }
        
    }
}