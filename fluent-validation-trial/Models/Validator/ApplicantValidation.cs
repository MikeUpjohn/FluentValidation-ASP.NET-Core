using FluentValidation;

namespace fluent_validation_trial.Models.Validator
{
    public class ApplicantValidation : AbstractValidator<Applicant>
    {
        public ApplicantValidation()
        {
            RuleFor(a => a.Title)
                .NotEmpty().WithMessage("Title is a required field.")
                .Length(2, 255).WithMessage("Title is not the correct length.");

            RuleFor(a => a.Forename)
                .NotEmpty().WithMessage("Forename is a required field.")
                .Length(1, 255).WithMessage("Forename is not the correct length.");

            RuleFor(a => a.Surname)
                .NotEmpty().WithMessage("Surname is a required field.")
                .Length(1, 255).WithMessage("Surname is a required field.");

            RuleFor(a => a.DateOfBirth)
                .NotEmpty().WithMessage("Date Of Birth is a required field")
                .Custom((dateOfBirth, context) =>
                {
                    var error = ApplicantValidatorRules.IsValidAge(dateOfBirth, 25, 60);
                    if (error != null) context.AddFailure(error);
                });

            RuleFor(a => a.Email)
                .NotEmpty().WithMessage("Email is a required field")
                .EmailAddress().WithMessage("Not a valid email address");

            RuleFor(a => a.MaritalStatus)
                .NotEmpty().WithMessage("Marital Status is a required field.");

            RuleFor(a => a.Nationality)
                .NotEmpty().WithMessage("Nationality is a required field.");

            RuleFor(a => a.HasChildren)
                .NotEmpty().WithMessage("Has Children is required");

            RuleFor(a => a.NumberOfChildren)
                .NotEmpty()
                .WithMessage("Number of children is a required field.");

            RuleFor(a => a.RetirementAge)
                .NotEmpty()
                .WithMessage("Retirement age is a required field");

            RuleFor(a => a.Telephone)
                .NotEmpty().WithMessage("Telephone is a required field")
                .Matches(
                    @"^(\+44\s?\d{10}|0044\s?\d{10}|0\s?\d{10})?$").WithMessage("Invalid telephone number");

            RuleFor(a => a.AddressHistory)
                .NotNull().WithMessage("Address History data must exist");

        }
    }
}
