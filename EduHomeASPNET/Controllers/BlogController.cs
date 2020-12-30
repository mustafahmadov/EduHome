using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHomeASPNET.DAL;
using EduHomeASPNET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHomeASPNET.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int? page)
        {
            TempData["controllerName"] = this.ControllerContext.RouteData.Values["controller"].ToString();
            ViewBag.PageCount = Decimal.Ceiling((decimal)_context.Blogs
                                           .Where(b => b.HasDeleted == false).Count() / 6);
            ViewBag.Page = page;
            if (page == null)
            {
                return View(await _context.Blogs.Include(blogs => blogs.Author).Where(b => b.HasDeleted == false)
                                                .OrderByDescending(b => b.Id).Take(6).ToListAsync());
            }

            return View(await _context.Blogs.Include(blogs => blogs.Author).Where(b => b.HasDeleted == false)
                                          .OrderByDescending(b => b.Id).Skip(((int)page - 1) * 6).Take(6).ToListAsync());
        }
        public IActionResult BlogDetail(int? id)
        {
            TempData["controllerName"] = this.ControllerContext.RouteData.Values["controller"].ToString();
            if (id == null) return NotFound();
            Blog blog = _context.Blogs.Include(b => b.BlogDetail).Include(b => b.Author)
                     .Where(t => t.HasDeleted == false && t.Id == id).FirstOrDefault();
            //List<Event> events = _context.Events.Include(e=>e.)
            return View(blog);

        }
    }
}
