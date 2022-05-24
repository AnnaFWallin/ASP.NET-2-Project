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
        private static string loginErrorMessage = "";
        private static string registerErrorMessage = "";

        public AuthController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            ViewData["LoginErrorMessage"] = loginErrorMessage;
            ViewData["RegisterErrorMessage"] = registerErrorMessage;
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
            loginErrorMessage = "Username or password was invalid";

            return RedirectToAction("Index", "Auth");
        }

        public async Task<IActionResult> Logout()
        {
            if (_signInManager.IsSignedIn(User))
                await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Auth");
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
                }
                
                registerErrorMessage = "Username needs to be unique. Email needs to be correct. Passwords must be at least 6 characters, have at least one non alphanumeric character, have at least one digit ('0'-'9') and have at least one uppercase ('A'-'Z')";
     
            }            
            return RedirectToAction("Index", "Auth");
        }
    }
}