using System.ComponentModel.DataAnnotations;

namespace BlazorValidation.Model
{
    public class UserNameValidation: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string inputValue = value.ToString();
                if (inputValue.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                {
                    return new ValidationResult("The input value cannot be 'Admin'.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
