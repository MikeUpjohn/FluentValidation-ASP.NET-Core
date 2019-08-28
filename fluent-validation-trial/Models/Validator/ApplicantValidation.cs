using FluentValidation;

namespace fluent_validation_trial.Models.Validator
{
    public class ApplicantValidation : AbstractValidator<Applicant>
    {
        public ApplicantValidation()
        {
            //RuleFor(a => a.Title).NotEmpty().WithMessage("Title is a required field.");
        }
    }
}
