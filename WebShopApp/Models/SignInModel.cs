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
        public string Password { get; set; }
    }
}
