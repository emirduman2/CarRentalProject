using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator:AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.CarId).NotEmpty().NotNull();
            RuleFor(r => r.CustomerId).NotEmpty().NotNull();
            RuleFor(r=> r.RentDate).NotEmpty().NotNull();

        }
    }
}