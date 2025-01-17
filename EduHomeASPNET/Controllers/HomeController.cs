﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EduHomeASPNET.Models;
using EduHomeASPNET.ViewModels;
using Microsoft.EntityFrameworkCore;
using EduHomeASPNET.DAL;
using Microsoft.AspNetCore.Identity;

namespace EduHomeASPNET.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,
                              AppDbContext context)
        {
            _logger = logger;
            _context = context;
   
        }

        public IActionResult Index()
        {
            TempData["controllerName"] = this.ControllerContext.RouteData.Values["controller"].ToString();
            HomeVM homeVM = new HomeVM()
            {
                Sliders = _context.Sliders.Where(s => s.HasDeleted == false).ToList(),
                LeftNotices = _context.LeftNotices.ToList(),
                RightNotices = _context.RightNotices.ToList(),
                Choose = _context.Chooses.FirstOrDefault(),
                Courses = _context.Courses.Where(c => c.HasDeleted == false).Take(3).ToList(),
                Events = _context.Events.Include(e => e.EventDetail)
                      .Where(e => e.HasDeleted == false && e.ExperiedDate == false).Take(8).ToList(),
                Blogs = _context.Blogs.Include(b => b.Author).Where(b => b.HasDeleted==false).OrderByDescending(b => b.Id).Take(3).ToList(),
                
            };
            return View(homeVM);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
