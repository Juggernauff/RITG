using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaskMVC.Models;

namespace TaskMVC.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Error(string message)
        {
            ViewBag.Message = message;
            return View();
        }
    }
}
