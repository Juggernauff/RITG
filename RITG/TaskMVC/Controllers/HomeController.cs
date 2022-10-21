using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TaskMVC.Models;

namespace TaskMVC.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ApplicationContext _context;

        public HomeController(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var applicationContext = _context.News.Include(n => n.User);
            return View(await applicationContext.ToListAsync());
        }
        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }
    }
}