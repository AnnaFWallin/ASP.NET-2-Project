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
        private readonly ApplicationDbContext _db;

        public AuthController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, ApplicationDbContext db)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _db = db;
        }
        //public IActionResult Index(string returnUrl = null!)
        public IActionResult Index()
        {

            if (_signInManager.IsSignedIn(User))
            {
                //My Account - ordrar och wishlist kanske?
                return View();
            }
            else
            {
                //Registrering och login - forms
                return RedirectToAction("Login");
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register(string returnUrl = null!)
        {
            if(_signInManager.IsSignedIn(User))
                return RedirectToAction("Index");

            var form = new RegisterFormModel();

            if(returnUrl != null)
                form.ReturnUrl = returnUrl;

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

                    if(form.ReturnUrl == null || form.ReturnUrl == "/")
                        return RedirectToAction("Index", "Home");
                    else
                        return LocalRedirect(form.ReturnUrl);
                }

            }


            ViewData["ErrorMessage"] = "The registration failed! Try again";
            return View();
        }

    }
}
