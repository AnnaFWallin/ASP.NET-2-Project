using Microsoft.AspNetCore.Mvc;

namespace WebShopApp.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
