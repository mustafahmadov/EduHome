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
        public IActionResult Index(int? page)
        {
            TempData["controllerName"] = this.ControllerContext.RouteData.Values["controller"].ToString();
            ViewBag.PageCount = Decimal.Ceiling((decimal)_context.Teachers.Where(t => t.HasDeleted == false).Count() / 8);
            ViewBag.Page = page;
            if (page == null)
            {
                return View(_context.Teachers.Where(t => t.HasDeleted == false).Take(8).ToList());
            }
            return View(_context.Teachers.Where(t => t.HasDeleted == false).Skip(((int)page - 1) * 8).Take(8).ToList());
        }

        public IActionResult TeacherDetail(int? id)
        {
            TempData["controllerName"] = this.ControllerContext.RouteData.Values["controller"].ToString();
            if (id == null) return NotFound();
            Teacher teacher = _context.Teachers.Include(t => t.TeacherDetail).Include(t => t.Skill)
                     .Where(t => t.HasDeleted == false && t.Id==id).FirstOrDefault();
            return View(teacher);
        }
        public IActionResult Search(string search)
        {
            if (search == null)
            {
                return View(_context.Teachers.Where(t => t.HasDeleted == false).Take(8).ToList());
            }
            IEnumerable<Teacher> model = _context.Teachers.Where(t => t.Name.Contains(search)).Take(8);
            if (model == null)
            {
                return Content("skjdlkjf");
            }
            return PartialView("_SearchTeacherPartial", model);
        }
    }
}
