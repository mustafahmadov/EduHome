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
        public IActionResult Index(int? page,int? categoryId)
        {
            TempData["controllerName"] = this.ControllerContext.RouteData.Values["controller"].ToString();
            ViewBag.CatBlogId = categoryId;
            if (categoryId == null)
            {
                ViewBag.PageCount = Decimal.Ceiling((decimal)_context.Blogs
                                           .Where(b => b.HasDeleted == false).Count() / 6);
                ViewBag.Page = page;
                return View();
            }
            List<CategoryBlog> categoryBlogs = _context.CategoryBlogs.Include(c => c.Blog).ThenInclude(b => b.Author)
                          .Include(c => c.Category).Where(cb => cb.CategoryId == categoryId && cb.Blog.HasDeleted == false).ToList();
            return View(categoryBlogs);
          
        }
        public IActionResult BlogDetail(int? id)
        {
            TempData["controllerName"] = this.ControllerContext.RouteData.Values["controller"].ToString();
            if (id == null) return NotFound();
            Blog blog = _context.Blogs.Include(b => b.BlogDetail).Include(b => b.Author)
                     .Where(t => t.HasDeleted == false && t.Id == id).FirstOrDefault();
            List<Event> events = _context.Events.Include(e => e.SpeakerEvents)
                                                    .ThenInclude(e => e.Speaker).ToList();
            return View(blog);

        }
        public IActionResult Search(string search)
        {
            IEnumerable<Blog> model = _context.Blogs.Where(t => t.Description.Contains(search)).Take(8);
            return PartialView("_SearchBlogPartial", model);
        }
    }
}
