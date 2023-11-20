using System.ComponentModel.DataAnnotations;

namespace BlazorValidation.Model
{
    public class Address
    {
        [Required] 
        public  string Address1 { get; set; }
        public string Address2 { get; set; }
    }
}
