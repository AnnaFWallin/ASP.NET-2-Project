using Microsoft.AspNetCore.Mvc;
using WebShopApp.Services;

namespace WebShopApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }


    }
}
