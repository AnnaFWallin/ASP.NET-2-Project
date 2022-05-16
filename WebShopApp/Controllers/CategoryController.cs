using Microsoft.AspNetCore.Mvc;
using WebShopApp.Interfaces;
using WebShopApp.Services;

namespace WebShopApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            return View(ViewBag.Category = await _service.GetAsync(cancellationToken));
        }


    }
}
