using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaskMVC.Models;

namespace TaskMVC.Controllers
{
    public class NewsController : Controller
    {
        private readonly ApplicationContext _context;

        public NewsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: News
        public async Task<IActionResult> Index()
        {
            var applicationContext = _context.News.Include(n => n.User);
            return View(await applicationContext.ToListAsync());
        }

        // GET: News/Create
        [Authorize(Policy = "Administrator")]
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["UserLogin"] = new SelectList(_context.Users, "Login", "Login");
            return View();
        }

        // POST: News/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(News news) // [Bind("Id,Title,Content,Published,UserId")] 
        {
            news.User = _context.Users.FirstOrDefault(u => u.Login == User.Identity.Name);
            news.UserId = news.User.Id;
            _context.Add(news);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
/*            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", news.UserId);
            return View(news);*/
        }

        // GET: News/Edit/5
        [Authorize(Policy = "Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            //int? id = _context.Users.FirstOrDefault(u => u.Login == User.Identity.Name).Id;
            if (id == null || _context.News == null)
            {
                return NotFound();
            }

            var news = await _context.News.FindAsync(id);
            if (news == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", news.UserId);
            return View(news);
        }

        // POST: News/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content,Published,UserId")] News news)
        {
            if (id != news.Id)
            {
                return NotFound();
            }
            try
            {
                _context.Update(news);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NewsExists(news.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: News/Delete/5
        [Authorize(Policy = "Administrator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.News == null)
            {
                return NotFound();
            }

            var news = await _context.News
                .Include(n => n.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        // POST: News/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.News == null)
            {
                return Problem("Entity set 'ApplicationContext.News'  is null.");
            }
            var news = await _context.News.FindAsync(id);
            if (news != null)
            {
                _context.News.Remove(news);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [Authorize]
        public async Task<IActionResult> ToPublish(int? id)
        {

            if (id == null || _context.News == null)
            {
                return NotFound();
            }

            var news = await _context.News.FindAsync(id);
            if (news == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", news.UserId);
            return View(news);
        }

        private bool NewsExists(int id)
        {
          return _context.News.Any(e => e.Id == id);
        }
    }
}
