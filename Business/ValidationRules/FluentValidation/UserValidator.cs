using Entities.Concrete;
using FluentValidation;
using System.Text.RegularExpressions;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            //FirstName
            RuleFor(u => u.FirstName).NotEmpty();

            //LastName
            RuleFor(u => u.LastName).NotEmpty();

            //Email
            RuleFor(u => u.Email).NotEmpty();

            //Password
            RuleFor(u => u.Password).NotEmpty();
            RuleFor(u => u.Password).MaximumLength(6);
            RuleFor(u => u.Password).Must(isContainsNumber);
        }

        private bool isContainsNumber(string arg)
        {
            Regex re = new Regex(@"\d+");
            Match m = re.Match(arg);
            return m.Success;
        }
    }
}
