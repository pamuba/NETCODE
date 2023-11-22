using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using ModelValidation.CustomValidators;
using System.ComponentModel.DataAnnotations;

namespace ModelValidation.Models
{
    public class Person : IValidatableObject
    {
        [Required(ErrorMessage = "{0} cant be empty or null")]
        [Display(Name = "Person Initial Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "{0} should " +
            "be between {2} and {1} characters long")]
        [RegularExpression("^[A-Za-z .]*$", ErrorMessage = "{0} should contain only chars or spaces or .")]
        public string? PersonName { get; set; }
        [EmailAddress(ErrorMessage = "{0} should be in proper format")]
        [BindNever]
        public string? Email { get; set; }
        [Phone(ErrorMessage = "{0} cannot contain chars")]
        [ValidateNever]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "{0} can't be blank")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "{0} can't be blank")]
        [Compare("Password", ErrorMessage = "{0} and {1} didn't match")]
        [Display(Name = "Re-enter password")]
        public string? ConfirmPassword { get; set; }
        [Range(0, 999999.99, ErrorMessage = "{0} should " +
            "be between {2} and {1}")]
        public double? Salary { get; set; }

        [MinimumYearValidator(2006,ErrorMessage = "Date of Birth should not be " +
            "older than {0}")]
        public DateTime? DateOfBirth { get; set; }

        public DateTime? Age { get; set; }

        [DateRangeValidator("FromDate", ErrorMessage = "'From Date' should be older " +
            "then or equal to 'To Date'")]
        public DateTime? ToDate { get; set; }

        public DateTime? FromDate { get; set; }



        public override string ToString()
        {
            return $"Person Object - Person Name:{PersonName}, Email:{Email}, Phone:{Phone}" +
                $"Password:{Password}, ConfirmPassword:{ConfirmPassword}, Salary:{Salary}";
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DateOfBirth.HasValue == false && Age.HasValue == false) {
                yield return new ValidationResult("Either DOB of AGE or BOTH should be provided",
                    new[] {nameof(Age)});
            }
        }
    }
}
