using Microsoft.AspNetCore.Mvc;
using WebShopApp.Interfaces;
using WebShopApp.Models;

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
            var productViewModel = new ProductViewModel();

            productViewModel.Product = await _service.GetProductById(id);
            return View(ViewBag.Product = productViewModel.Product);
        }
    }
}
