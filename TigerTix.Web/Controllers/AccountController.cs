// Controllers/AccountController.cs
using Microsoft.AspNetCore.Mvc;
using TigerTix.Web.Models;

namespace TigerTix.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
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

        public IActionResult Logout()
        {
            // Placeholder for logout logic
            return RedirectToAction("Index", "Home");
        }
    }
}