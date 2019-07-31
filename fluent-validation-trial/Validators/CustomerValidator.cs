using fluent_validation_trial.Models;
using FluentValidation;

namespace fluent_validation_trial.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Title is a required field.")
                .MinimumLength(2).WithMessage("Title must be at least 2 characters");
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("First Name is a required field.")
                .MaximumLength(255).WithMessage("First Name must be less than 255 characters.");
            RuleFor(x => x.Surname).
                NotEmpty().WithMessage("Surname is a required field.")
                .MaximumLength(255).WithMessage("Surname must be less than 255 characters.");
            RuleFor(x => x.Age)
                .NotEmpty().WithMessage("Age is a required field")
                .GreaterThan(18).WithMessage("You must be at least 18.");
            RuleFor(x => x.MaritalStatus).NotEmpty().WithMessage("Marital Status is a required field.");
        }
    }
}
