using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebShopApp.Data;
using WebShopApp.Models;

namespace WebShopApp.Controllers
{
    public class AuthController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        //private readonly ApplicationDbContext _db;

        public AuthController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        //public IActionResult Index(string returnUrl = null!)
        public IActionResult Index()
        {
                return View();            
        }

        [HttpPost]
        public async Task<IActionResult> Login(SignInModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, isPersistent: false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Auth");
                }
            }
            ModelState.AddModelError(string.Empty, "Invalid username or password");

            return RedirectToAction("Index", "Auth");
        }

        public async Task<IActionResult> Logout()
        {
            if (_signInManager.IsSignedIn(User))
                await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Auth");
        }

        public IActionResult Register()
        {
            if(_signInManager.IsSignedIn(User))
                return RedirectToAction("Index", "Auth");

            var form = new RegisterFormModel();

            //if(returnUrl != null)
            //    form.ReturnUrl = returnUrl;

            return View(form);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterFormModel form)
        {
            if (ModelState.IsValid)
            {
                var identityUser = new IdentityUser() { UserName = form.UserName, Email = form.Email };                
                var result = await _userManager.CreateAsync(identityUser, form.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(identityUser, isPersistent: false);

                    return RedirectToAction("Index", "Auth");

                    //if (form.ReturnUrl == null || form.ReturnUrl == "/")
                    //    return RedirectToAction("Index", "Home");
                    //else
                    //    return LocalRedirect(form.ReturnUrl);
                }

            }

            ViewData["ErrorMessage"] = "The registration failed! Try again";
            return View(form);
        }

    }
}
