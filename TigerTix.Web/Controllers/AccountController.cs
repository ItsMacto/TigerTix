using Microsoft.AspNetCore.Mvc;
using TigerTix.Web.Models;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace TigerTix.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AccountController(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor)
        {
            _httpClient = httpClientFactory.CreateClient("ApiClient");
            _httpContextAccessor = httpContextAccessor;

            // Set the BaseAddress to the current request's base URL
            var request = _httpContextAccessor.HttpContext?.Request;
            if (request != null)
            {
                _httpClient.BaseAddress = new Uri($"{request.Scheme}://{request.Host}");
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            var loginRequest = new LoginRequest
            {
                Username = username,
                Password = password
            };

            var response = await _httpClient.PostAsJsonAsync("api/AccountsApi/Login", loginRequest);
            if (response.IsSuccessStatusCode)
            {
                var dbUser = await response.Content.ReadFromJsonAsync<User>();

                // Create claims based on user information
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, dbUser.Username),
                    new Claim(ClaimTypes.NameIdentifier, dbUser.Id.ToString()),
                    new Claim(ClaimTypes.Email, dbUser.Email ?? ""),
                    new Claim("FullName", dbUser.FullName ?? "")
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                // Authentication properties
                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true, // Keeps the user logged in
                    ExpiresUtc = DateTimeOffset.UtcNow.AddDays(7)
                };

                // Sign in the user
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Invalid login attempt.");
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {
            var response = await _httpClient.PostAsJsonAsync("api/AccountsApi/Register", user);
            if (response.IsSuccessStatusCode)
            {
                // Optionally log the user in after successful registration
                return await Login(user.Username, user.Password);
            }

            var errorContent = await response.Content.ReadAsStringAsync();
            ModelState.AddModelError("", $"Registration failed: {errorContent}");
            return View(user);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}