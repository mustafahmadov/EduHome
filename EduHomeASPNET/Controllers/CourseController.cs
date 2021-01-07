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
        public IActionResult Index(int? page,int? categoryCourseId)
        {
            TempData["controllerName"] = this.ControllerContext.RouteData.Values["controller"].ToString();
            ViewBag.CatId = categoryCourseId;
            if (categoryCourseId == null)
            {
                ViewBag.PageCount = Decimal.Ceiling((decimal)_context.Courses
                                               .Where(t => t.HasDeleted == false).Count() / 6);
                ViewBag.Page = page;
            }
            List<CategoryCourse> courses = _context.CategoryCourses.Include(c => c.Course)
                         .Include(c => c.Category).Where(c=>c.CategoryId==categoryCourseId && c.Course.HasDeleted==false).ToList();
            return View(courses);
            
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
            IEnumerable<Course> model = _context.Courses.Where(t => t.Name.Contains(search)).Take(8);
            return PartialView("_SearchCoursePartial", model);
        }
    }
}
