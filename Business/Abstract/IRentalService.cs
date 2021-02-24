using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetRentalInfoByRentalId(int rentalId);
        IDataResult<Rental> GetRentalInfoByRentalCarId(int rentalCarId);
        IDataResult<Rental> GetRentalInfoByCustomerId(int rentalCustomerId);

        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);

        IDataResult<List<RentalDetailDto>> GetRentalDetailDtos();
    }
}