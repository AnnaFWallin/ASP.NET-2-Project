using Microsoft.AspNetCore.Mvc;

namespace WebShopApp.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index(string returnUrl = null)
        {
            if (_signInManager.IsSignedIn(User))
            {
                //My Account - ordrar och wishlist kanske?
                return View();
            }
            else
            {
                //Registrering och login - forms
                return View();
            }
        }
    }
}
