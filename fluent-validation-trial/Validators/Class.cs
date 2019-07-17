using fluent_validation_trial.Models;
using FluentValidation;

namespace fluent_validation_trial.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title is a required field.");
            RuleFor(x => x.Title).MinimumLength(2).WithMessage("Title must be at least 2 characters");
            RuleFor(x => x.Title).Custom((x, y) =>
              {
                  if(x.Contains("M"))
                  {
                      y.AddFailure("Title contains the letter M!");
                  }
              });
        }
    }
}
