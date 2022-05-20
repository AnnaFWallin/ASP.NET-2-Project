using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebShopApp.Models;
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
            var viewModel = new HomeIndexViewModel();

            ShoppingCartModel shoppingCart;
            try { shoppingCart = JsonConvert.DeserializeObject<ShoppingCartModel>(HttpContext.Session.GetString("ShoppingCart")); }
            catch { shoppingCart = new ShoppingCartModel(); }

            viewModel.ShoppingCart = shoppingCart;

            return View(viewModel);
        }

        public async Task<IActionResult> AddToCart(int id)
        {
            var shoppingCart = new ShoppingCartModel();
            var cartSession = HttpContext.Session.GetString("ShoppingCart");

            if (!string.IsNullOrEmpty(cartSession))
            {
                shoppingCart = JsonConvert.DeserializeObject<ShoppingCartModel>(cartSession);

                var index = shoppingCart.ShoppingCart.FindIndex(x => x.Product.Id == id);
                if (index > -1)
                    shoppingCart.ShoppingCart[index].Quantity += 1;
                else
                    shoppingCart.ShoppingCart.Add(new CartItemModel { Product = await _productRepository.GetAsync(id) });
            }
            else
            {
                shoppingCart.ShoppingCart.Add(new CartItemModel { Product = await _productRepository.GetAsync(id) });
            }

            HttpContext.Session.SetString("ShoppingCart", JsonConvert.SerializeObject(shoppingCart));

            return RedirectToAction("Index", "ShoppingCart");

            //ViewData["ShoppingCart"] = HttpContext.Session.GetString("ShoppingCart");
            //return View();
        }
        public async Task<IActionResult> RemoveFromCart(int id)
        {
            var shoppingCart = new ShoppingCartModel();
            var cartSession = HttpContext.Session.GetString("ShoppingCart");

            shoppingCart = JsonConvert.DeserializeObject<ShoppingCartModel>(cartSession);

            var index = shoppingCart.ShoppingCart.FindIndex(x => x.Product.Id == id);
            if (shoppingCart.ShoppingCart[index].Quantity > 1)
                shoppingCart.ShoppingCart[index].Quantity -= 1;
            else
                shoppingCart.ShoppingCart.Remove(shoppingCart.ShoppingCart[index]);

            HttpContext.Session.SetString("ShoppingCart", JsonConvert.SerializeObject(shoppingCart));
            return RedirectToAction("Index", "ShoppingCart");
        }
        public async Task<IActionResult> RemoveItemFromCart(int id)
        {
            var shoppingCart = new ShoppingCartModel();
            var cartSession = HttpContext.Session.GetString("ShoppingCart");

            shoppingCart = JsonConvert.DeserializeObject<ShoppingCartModel>(cartSession);

            var index = shoppingCart.ShoppingCart.FindIndex(x => x.Product.Id == id);
            shoppingCart.ShoppingCart.Remove(shoppingCart.ShoppingCart[index]);

            HttpContext.Session.SetString("ShoppingCart", JsonConvert.SerializeObject(shoppingCart));
            return RedirectToAction("Index", "ShoppingCart");

        }
    }
}
