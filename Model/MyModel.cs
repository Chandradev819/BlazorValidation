using System.ComponentModel.DataAnnotations;

namespace BlazorValidation.Model
{
    public class MyModel
    {
        [Required(ErrorMessage = "Name is required")]
        [UserNameValidation]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

    }
}
