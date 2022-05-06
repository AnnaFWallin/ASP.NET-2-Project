using Microsoft.AspNetCore.Mvc;
using WebShopApp.Services;

namespace WebShopApp.Controllers
{
    public class ShopPageController : Controller
    {
        private readonly IProductService _service;

        public ShopPageController(IProductService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            return View(ViewBag.Products = await _service.GetProducts());
        }

        public async Task<IActionResult> Category(int id)
        {
            return View("Index", ViewBag.Products = await _service.GetProductByCategory(id));
        }

        public async Task<IActionResult> Color(string id)
        {
            return View("Index", ViewBag.Products = await _service.GetProductByColor(id));
        }
        public async Task<IActionResult> Size(string id)
        {
            return View("Index", ViewBag.Products = await _service.GetProductBySize(id));
        }

    }
}
