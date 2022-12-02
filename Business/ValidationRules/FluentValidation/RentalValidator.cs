using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            //CustomerId
            RuleFor(r => r.CustomerId).NotEmpty();

            //CardId
            RuleFor(r => r.CarId).NotEmpty();

            //RentDate
            RuleFor(r => r.RentDate).GreaterThan(r => r.RentDate);
        }
    }
}
