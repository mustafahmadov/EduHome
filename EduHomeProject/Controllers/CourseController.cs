using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHomeProject.DAL;
using EduHomeProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EduHomeProject.Controllers
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
        public IActionResult Index()
        {
            TempData["controllerName"] = this.ControllerContext.RouteData.Values["controller"].ToString();
            return View();
        }
        public IActionResult CourseDetail(int? id)
        {
            
            TempData["controllerName"] = this.ControllerContext.RouteData.Values["controller"].ToString();
            if (id == null) return NotFound();
            Course course = _context.Courses.Where(c => c.HasDeleted == false && c.Id == id).Include(c => c.CourseDetail).FirstOrDefault();
            return View(course);
        }
    }
}
