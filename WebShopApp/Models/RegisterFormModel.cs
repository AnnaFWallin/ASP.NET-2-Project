using System.ComponentModel.DataAnnotations;

namespace WebShopApp.Models
{
    public class RegisterFormModel
    {
        [Required (ErrorMessage = "You need to put in a Username")]
        public string UserName { get; set; } = null!;

        [Required (ErrorMessage = "You need to put in an Email address")]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required (ErrorMessage = "You need to put in a Password")]
        [DataType (DataType.Password)]
        [StringLength(50, ErrorMessage = "The must be at least 8 figures and contain numbers", MinimumLength = 8)]
        
        public string Password { get; set; } = null!;

        public string ReturnUrl { get; set; } = "/";
    }
}
