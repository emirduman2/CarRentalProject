using System;
using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetRentalInfoByRentalId(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.RentalId == rentalId));
        }

        public IDataResult<Rental> GetRentalInfoByRentalCarId(int rentalCarId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.CarId == rentalCarId));
        }

        public IDataResult<Rental> GetRentalInfoByCustomerId(int rentalCustomerId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.CustomerId == rentalCustomerId));
        }
        
        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate == null && rental.ReturnDate > DateTime.Now)
            {
                return new ErrorResult(Messages.TimeError);
            }
            else
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.CarRented);
            }
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetailDtos()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }
    }
}