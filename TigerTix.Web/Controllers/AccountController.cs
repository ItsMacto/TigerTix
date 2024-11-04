// Controllers/AccountController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Threading.Tasks;
using TigerTix.Web.Data;
using TigerTix.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace TigerTix.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            // Find the user in the database by username
            var dbUser = await _context.Users.SingleOrDefaultAsync(u => u.Username == user.Username);

            if (dbUser != null)
            {
                var passwordHasher = new PasswordHasher<User>();
                var result = passwordHasher.VerifyHashedPassword(dbUser, dbUser.Password, user.Password);

                if (result == PasswordVerificationResult.Success)
                {
                    // Create a list of claims. Here, we're adding the username as a claim.
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, dbUser.Username)
                    };

                    // Create the claims identity
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    // Sign in the user with the created claims principal
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                    // Redirect to home after successful login
                    return RedirectToAction("Index", "Home");
                }
            }

            // If login fails, add an error and return to the login view
            ModelState.AddModelError("", "Invalid login attempt.");
            return View(user);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {
            if (ModelState.IsValid)
            {
                // Hash the password before storing it
                var passwordHasher = new PasswordHasher<User>();
                user.Password = passwordHasher.HashPassword(user, user.Password);

                // Save the user to the database
                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                // Redirect to the login page after successful registration
                return RedirectToAction("Login");
            }

            // If the model state is invalid, return the user to the registration form
            return View(user);
        }

        public async Task<IActionResult> Logout()
        {
            // Sign out the user by removing the authentication cookie
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            // Redirect to the homepage after logout
            return RedirectToAction("Index", "Home");
        }
    }
}
