using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace ModelValidation.CustomValidators
{
    public class DateRangeValidator : ValidationAttribute
    {
        public string OtherPropertyName { get; set; }
        public DateRangeValidator(string otherPropertyName) {
            OtherPropertyName = otherPropertyName;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            //all other class use this class to access propertt
            if (value != null) {
                DateTime to_date = Convert.ToDateTime(value);

                PropertyInfo? otherProperty = 
                    validationContext.ObjectType.GetProperty(OtherPropertyName);

                if (otherProperty != null) {
                    DateTime from_date = Convert.ToDateTime(otherProperty.GetValue(validationContext.ObjectInstance));


                    if (from_date > to_date)
                    {
                        return new ValidationResult(ErrorMessage, new string[]
                        { OtherPropertyName, validationContext.MemberName});
                    }
                    return ValidationResult.Success;
                }

                return null;
            }
            return null;
        }
    }
}
