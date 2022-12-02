using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            //BrandId
            RuleFor(c => c.BrandId).NotEmpty();

            //ColorId
            RuleFor(c => c.ColorId).NotEmpty();

            //DailyPrice
            RuleFor(c => c.DailyPrice).GreaterThan(500_000).When(c => c.ModelYear > 2020);
        }
    }
}
