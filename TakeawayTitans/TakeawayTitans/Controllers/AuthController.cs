using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using TakeawayTitans.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TakeawayTitans.Data;

namespace TakeawayTitans.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IDbContextFactory<TakeawayTitansContext> _dbFactory;
        public AuthController(IDbContextFactory<TakeawayTitansContext> dbFactory)
        {
            _dbFactory = dbFactory;
        }

        [HttpPost("admin-login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest dto)
        {
            using var db = _dbFactory.CreateDbContext();

            var user = await db.Users.AsNoTracking().FirstOrDefaultAsync(user => user.Email == dto.Email);
            if (user is null) return Unauthorized("Invalid email or password");

            if (!BCrypt.Net.BCrypt.Verify(dto.Password, user.PasswordHash))
                return Unauthorized("Invalid email or password.");

            var claims = new List<Claim>
            {
                new (ClaimTypes.NameIdentifier, user.Email),
                new (ClaimTypes.Name, user.FirstName ?? user.Email),
                new (ClaimTypes.Email, user.Email),
                new (ClaimTypes.Role, user.Role.ToString())
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            var props = new AuthenticationProperties
            {
                IsPersistent = dto.RememberMe,
            };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props);
            return Ok();
        }

        [HttpPost("admin-logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Ok();
        }

        [HttpGet("me")]
        public ActionResult<AuthInfo> Me()
        {
            var u = HttpContext.User;
            return new AuthInfo(
                u.Identity?.Name,
                u.Identity?.IsAuthenticated ?? false,
                u.Claims.Select(c => new KeyValuePair<string, string>(c.Type, c.Value)));
        }
    }
}
