using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebShopApp.Interfaces;
using WebShopApp.Models;

namespace WebShopApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryService _categoryService;
        private readonly IArrivalService _arrivalService;

        public HomeController(ILogger<HomeController> logger, ICategoryService categoryService, IArrivalService arrivalService)
        {
            _logger = logger;
            _categoryService = categoryService;
            _arrivalService = arrivalService;  
        }

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            ViewBag.Categories = await _categoryService.GetAsync(cancellationToken);
            ViewBag.Arrivals = await _arrivalService.GetAsync(cancellationToken);

            return View();
        }

        public IActionResult RenderArrivalsView()
        {
            return PartialView("_SectionNewArrival");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}