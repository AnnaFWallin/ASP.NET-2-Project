using System.ComponentModel.DataAnnotations;

namespace WebShopApp.Models
{
    public class SignInModel
    {
        [Required(ErrorMessage = "You need to put in a username")]
        public string UserName { get; set; }

        //public string Email { get; set; }

        [Required(ErrorMessage = "Unvalid password")]
        [DataType(DataType.Password)]
        [StringLength(50, ErrorMessage = "The must be at least 8 figures and contain numbers", MinimumLength = 8)]
        
        public string Password { get; set; }
    }
}
