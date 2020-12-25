using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHomeASPNET.DAL;
using EduHomeASPNET.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EduHomeASPNET.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Title = "About Us";
            TempData["controllerName"] = this.ControllerContext.RouteData.Values["controller"].ToString();

            HomeVM homeVM = new HomeVM()
            {
                About = _context.Abouts.FirstOrDefault(),
            };

            return View(homeVM);
        }
    }
}
