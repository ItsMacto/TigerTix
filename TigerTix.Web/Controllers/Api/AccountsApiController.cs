using Microsoft.AspNetCore.Mvc;
using TigerTix.Web.Data;
using TigerTix.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace TigerTix.Web.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly PasswordHasher<User> _passwordHasher;

        public AccountsApiController(ApplicationDbContext context)
        {
            _context = context;
            _passwordHasher = new PasswordHasher<User>();
        }

        // POST: api/AccountsApi/Register
        [HttpPost("Register")]
        public async Task<IActionResult> Register(User user)
        {
            if (await _context.Users.AnyAsync(u => u.Username == user.Username))
            {
                return BadRequest("Username already exists.");
            }

            user.Password = _passwordHasher.HashPassword(user, user.Password);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // POST: api/AccountsApi/Login
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var dbUser = await _context.Users.SingleOrDefaultAsync(u => u.Username == request.Username);
            if (dbUser == null)
            {
                return Unauthorized();
            }

            var result = _passwordHasher.VerifyHashedPassword(dbUser, dbUser.Password, request.Password);
            if (result != PasswordVerificationResult.Success)
            {
                return Unauthorized();
            }

            // Return user data (excluding sensitive information)
            var userData = new User
            {
                Id = dbUser.Id,
                Username = dbUser.Username,
                FullName = dbUser.FullName,
                Email = dbUser.Email,
                IsStudentAccount = dbUser.IsStudentAccount,
                CUID = dbUser.CUID
                // Do not include the Password property
            };

            return Ok(userData);
        }
    }
}