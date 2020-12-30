using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHomeASPNET.DAL;
using EduHomeASPNET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EduHomeASPNET.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ILogger<CourseController> _logger;

        public CourseController(ILogger<CourseController> logger,
                              AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index(int? page)
        {
            TempData["controllerName"] = this.ControllerContext.RouteData.Values["controller"].ToString();
            ViewBag.PageCount = Decimal.Ceiling((decimal)_context.Courses.Where(t => t.HasDeleted == false).Count() / 6);
            ViewBag.Page = page;
            if (page == null)
            {
                return View(_context.Courses.Where(t => t.HasDeleted == false).Take(6).ToList());
            }
            return View(_context.Courses.Where(t => t.HasDeleted == false).Skip(((int)page - 1) * 6).Take(6).ToList());
        }
        public IActionResult CourseDetail(int? id)
        {
            
            TempData["controllerName"] = this.ControllerContext.RouteData.Values["controller"].ToString();
            if (id == null) return NotFound();
            Course course = _context.Courses.Where(c => c.HasDeleted == false && c.Id == id)
                                                .Include(c => c.CourseDetail).FirstOrDefault();
            return View(course);
        }
        public IActionResult Search(string search)
        {
            if (search == null)
            {
                return View(_context.Courses.Where(t => t.HasDeleted == false).Take(6).ToList());
            }
            IEnumerable<Course> model = _context.Courses.Where(p => p.Name.Contains(search)).OrderByDescending(p => p.Id).Take(6);
            if (model == null)
            {
                return Content("skjdlkjf");
            }
            return PartialView("_SearchCoursePartial", model);
        }
    }
}
