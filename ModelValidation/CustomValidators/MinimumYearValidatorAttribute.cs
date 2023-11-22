using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace ModelValidation.CustomValidators
{
    public class MinimumYearValidatorAttribute: ValidationAttribute
    {
        public int MaximumYear { get; set; } = 2000;
        public MinimumYearValidatorAttribute() { }
        public MinimumYearValidatorAttribute(int maximumYear)
        {
            MaximumYear = maximumYear;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null) {
                DateTime date = (DateTime)value;
                if (date.Year <= MaximumYear)
                {
                    return new ValidationResult(string.Format(ErrorMessage, MaximumYear));
                }
                else {
                    return ValidationResult.Success;
                }
            }
            return null;
        }
    }
}

