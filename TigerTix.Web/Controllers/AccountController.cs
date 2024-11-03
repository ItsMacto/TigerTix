// Controllers/AccountController.cs
using Microsoft.AspNetCore.Mvc;
using TigerTix.Web.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace TigerTix.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public  async Task<IActionResult> Login(User user)
        {

            // For demonstration, assume the user credentials are valid.
            // TODO: Add real authentication logic here to verify the user credentials.

            // Create a list of claims. Here, we're adding the username as a claim.
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username)
            };

            // Create the claims identity
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            // Sign in the user with the created claims principal
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

            // Since we're not implementing logic, redirect to home
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            // Since we're not implementing logic, redirect to login
            return RedirectToAction("Login");
        }

        public async Task<IActionResult> Logout()
        {
            // Sign out the user by removing the authentication cookie
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            // Placeholder for logout logic
            return RedirectToAction("Index", "Home");
        }
    }
}