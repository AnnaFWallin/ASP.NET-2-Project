using Microsoft.AspNetCore.Mvc;

namespace WebShopApp.Controllers
{
    public class ShopPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
