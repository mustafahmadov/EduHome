using EduHomeASPNET.DAL;
using EduHomeASPNET.Models;
using FrontToUp.Extentions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public CourseController(AppDbContext context,
                               IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Course> courses = _context.Courses.Include(c=>c.CourseDetail).Where(c => c.HasDeleted == false).ToList();
            return View(courses);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Course course = await _context.Courses.Include(c => c.CourseDetail).FirstOrDefaultAsync(c => c.Id == id);
            if (course == null) return NotFound();

            return View(course);
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = _context.Categories.Where(c=>c.HasDeleted==false).ToList();
            ViewBag.Tags = _context.Tags.Where(t => t.HasDeleted == false).ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Course course)
        {
            Course nCourse = new Course();
            CourseDetail nCourseDetail = new CourseDetail();
            if (course.Photo==null)
            {
                ModelState.AddModelError("Photo", "Shekil bolmesi bosh qala bilmez!");
                return View();
            }
            if (course.Name == null)
            {
                ModelState.AddModelError("Name", "Zehmet olmasa kursunuzun adini daxil edin");
                return View();
            }
            if (course.CourseDetail.Language == null)
            {
                ModelState.AddModelError("Name", "Dili daxil edin");
                return View();
            }
            if (course.CourseDetail.Price == null)
            {
                ModelState.AddModelError("Name", "Zehmet olmasa qiymeti daxil edin");
                return View();
            }
            if (course.CourseDetail.SkillLevel == null)
            {
                ModelState.AddModelError("Name", "Zehmet olmasa seviyeleri daxil edin");
                return View();
            }

            if (!course.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa shekil formati sechin");
                return View();
            }

            if (course.Photo.MaxLength(200))
            {
                ModelState.AddModelError("Photo", "Sheklin maksimum olcusu 200 kb ola biler");
                return View();
            }

            string folder = Path.Combine("assets", "img", "slider");
            string fileName = await course.Photo.SaveImg(_env.WebRootPath, folder);

            nCourse.Image = fileName;
            nCourse.Name = course.Name;
            nCourse.Description = course.Description;
            nCourse.HasDeleted = false;
            
            await _context.Courses.AddAsync(nCourse);
            await _context.SaveChangesAsync();

            nCourseDetail.About = course.CourseDetail.About;
            nCourseDetail.AboutApply = course.CourseDetail.AboutApply;
            nCourseDetail.AboutCertification = course.CourseDetail.AboutCertification;
            nCourseDetail.Duration = course.CourseDetail.Duration;
            nCourseDetail.ClassDuration = course.CourseDetail.ClassDuration;
            nCourseDetail.SkillLevel = course.CourseDetail.SkillLevel;
            nCourseDetail.Language = course.CourseDetail.Language;
            nCourseDetail.StudentsCount = course.CourseDetail.StudentsCount;
            nCourseDetail.StudentsCount = course.CourseDetail.StudentsCount;
            nCourseDetail.Price = course.CourseDetail.Price;
            nCourseDetail.CourseId = nCourse.Id;
            nCourse.CourseDetailId = nCourseDetail.Id;

            await _context.AddAsync(nCourseDetail);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
