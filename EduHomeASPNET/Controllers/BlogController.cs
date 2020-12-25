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
        public IActionResult Index()
        {
            TempData["controllerName"] = this.ControllerContext.RouteData.Values["controller"].ToString();
            return View();
        }
        public IActionResult BlogDetail(int? id)
        {
            TempData["controllerName"] = this.ControllerContext.RouteData.Values["controller"].ToString();
            if (id == null) return NotFound();
            Blog blog = _context.Blogs.Include(b => b.BlogDetail).Include(b => b.Author)
                     .Where(t => t.HasDeleted == false && t.Id == id).FirstOrDefault();
            return View(blog);

        }
    }
}
