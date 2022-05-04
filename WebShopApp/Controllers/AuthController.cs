using Microsoft.AspNetCore.Mvc;

namespace WebShopApp.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
