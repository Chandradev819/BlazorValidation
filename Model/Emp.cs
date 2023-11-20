using System.ComponentModel.DataAnnotations;

namespace BlazorValidation.Model
{
    public class Emp
    {
        [Required(ErrorMessage = "Name is required")]
        [UserNameValidation]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Address is required")]
        [ValidateComplexType]
        public Address Address { get; set; } = new();
       
    }
}
