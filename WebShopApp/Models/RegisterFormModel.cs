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
        public string Password { get; set; } = null!;

        public string ReturnUrl { get; set; } = "/";
    }
}
