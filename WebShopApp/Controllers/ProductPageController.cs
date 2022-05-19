using Microsoft.AspNetCore.Mvc;
using WebShopApp.Interfaces;

namespace WebShopApp.Controllers
{
    public class ProductPageController : Controller
    {
        private readonly IProductService _service;

        public ProductPageController(IProductService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index(int id)
        {
            return View(ViewBag.Product = await _service.GetProductById(id));
        }
    }
}
