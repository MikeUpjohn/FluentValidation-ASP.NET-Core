﻿using System;
using FluentValidation.Results;
using Microsoft.AspNetCore.Razor.Language.Extensions;

namespace fluent_validation_trial.Models.Validator
{
    public static class ApplicantValidatorRules
    {
        public static ValidationFailure IsValidAge(DateTime date, int minAge, int maxAge)
        {
            if (date >= DateTime.Today) return new ValidationFailure("DateOfBirth", "Property 'dateOfBirth' cannot be a future date.");
            if (date > DateTime.Today.AddYears(-minAge)) return new ValidationFailure("DateOfBirth", $"Applicant must be at least {minAge} years old to complete this application.");
            if (date < DateTime.Today.AddYears(-maxAge)) return new ValidationFailure("DateOfBirth", $"Applicant must be younger than {maxAge} years old to complete this application.");
            return null;
        }

        public static bool IsValidAgeV2(DateTime date, int minAge, int maxAge)
        {
            if (date >= DateTime.Today) return false;
            if (date > DateTime.Today.AddYears(-minAge)) return false;
            if (date < DateTime.Today.AddYears(-maxAge)) return false;

            return true;
        }
    }
}
