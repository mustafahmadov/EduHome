using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHomeASPNET.DAL;
using Microsoft.AspNetCore.Mvc;

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
    }
}
