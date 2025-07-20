using LaosEmployee.DBContext;
using LaosEmployee.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace LaosEmployee.Controllers
{
 
    public class LoginController : Controller
    {
        private readonly AppDbContext _context;

        public LoginController(AppDbContext context)
        {
            _context = context;
        }

        public class LoginRequest
        {
            public string Id { get; set; } = string.Empty;
            public string Password { get; set; } = string.Empty;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var user = await _context.UserLogins
                .FirstOrDefaultAsync(u => u.Id == request.Id && u.Password == request.Password);

            if (user == null)
                return Unauthorized(new { message = "Invalid username or password" });

            return Ok(new { message = "Login successful", userId = user.Id });
        }

        [HttpPost("api/login")]
        public async Task<IActionResult> ApiLogin([FromBody] LoginRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Id) || string.IsNullOrWhiteSpace(request.Password))
                return BadRequest(new { message = "Username and password are required." });

            var usernameParam = new SqlParameter("@Username", request.Id);
            var passwordParam = new SqlParameter("@Password", request.Password);

            var result = await _context.Set<LoginResponseDto>()
                .FromSqlRaw("EXEC sp_LoginUser @Username, @Password", usernameParam, passwordParam)
                .ToListAsync();

            if (result.Count == 0)
                return Unauthorized(new { message = "Invalid username or password." });

            return Ok(result.First());
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Authen(UserLogin model)
        {
            // ... ตรวจสอบ username/password ...
            if (true)
            {
                //HttpContext.Session.SetString("UserId", model.Id.ToString());
                HttpContext.Session.SetString("UserId", "1");
                return RedirectToAction("Index", "Home");
            }
            // ... กรณี login fail ...
            //return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Logout()
        {
            // Clear all session data
            HttpContext.Session.Clear();

            // Optional: clear authentication cookies if used
            //await HttpContext.SignOutAsync();

            // Redirect to login page
            return RedirectToAction("Index", "Login");
        }

    }
}
