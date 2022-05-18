using Microsoft.AspNetCore.Mvc;
using WebShopApp.Repository;

namespace WebShopApp.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ShoppingCartController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddToCart(int id)
        {

            return RedirectToAction("Index", "Home");
        }
    }
}
