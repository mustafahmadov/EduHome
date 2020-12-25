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
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;
        public TeacherController(AppDbContext context)
        {
            _context=context;
        }
        public IActionResult Index()
        {
            TempData["controllerName"] = this.ControllerContext.RouteData.Values["controller"].ToString();
            return View();
        }
        public IActionResult TeacherDetail(int? id)
        {
            TempData["controllerName"] = this.ControllerContext.RouteData.Values["controller"].ToString();
            if (id == null) return NotFound();
            Teacher teacher = _context.Teachers.Include(t => t.TeacherDetail).Include(t => t.Skill)
                     .Where(t => t.HasDeleted == false && t.Id==id).FirstOrDefault();
            return View(teacher);
        }
    }
}
