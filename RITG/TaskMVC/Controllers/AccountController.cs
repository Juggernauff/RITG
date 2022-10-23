using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TaskMVC.Models;

namespace TaskMVC.Controllers
{
    public class AccountController : BaseController
    {
        private ApplicationContext _db;
        public AccountController(ApplicationContext context)
        {
            _db = context;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model); // Исправить, если получится. (Base -> Error).
            }

            User user = null;
            Role role = null;
            try
            {
                user = _db.Users.FirstOrDefault(u => u.Login == model.Login && u.Password == model.Password);
                if (user != null)
                {
                    role = _db.Roles.FirstOrDefault(r => r.Id == user.RoleId || r.Equals(user.Role));
                    var claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.Role, role.Name));

                    claims.Add(new Claim(ClaimTypes.Name, user.Login));
                    var claimIdentity = new ClaimsIdentity(claims, "Cookie");
                    var claimPrincipal = new ClaimsPrincipal(claimIdentity);
                    await HttpContext.SignInAsync("Cookie", claimPrincipal);
                    return Redirect("/Home/Index");
                }
            }
            catch
            {
                return View(model);
            }
            return View();
        }

        public IActionResult LogOff()
        {
            HttpContext.SignOutAsync("Cookie");
            return Redirect("/Account/Login");
        }
    }
}
