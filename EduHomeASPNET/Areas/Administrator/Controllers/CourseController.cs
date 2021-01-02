using EduHomeASPNET.DAL;
using EduHomeASPNET.Models;
using FrontToUp.Extentions;
using FrontToUp.Helpers;
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
            List<Course> courses = _context.Courses.Where(c => c.HasDeleted == false)
                .Include(c => c.CourseDetail).ToList();
            return View(courses);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Course course = await _context.Courses.Include(c => c.CourseDetail).FirstOrDefaultAsync(c => c.Id == id);
            if (course == null) return NotFound();

            return View(course);
        }
        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.Where(c=>c.HasDeleted==false).ToList();
            ViewBag.Tags = _context.Tags.Where(t => t.HasDeleted == false).ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Course course, List<int> TagId,List<int> CategoryId)
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
            string fileName = await course.Photo.SaveImgAsync(_env.WebRootPath, folder);

            List<CategoryCourse> categoryCourses = new List<CategoryCourse>();
            List<CourseTag> tagCourses = new List<CourseTag>();
            
            if (CategoryId.Count == 0)
            {
                ModelState.AddModelError("", "Kategoriya bosh ola bilmez");
                return View();
            }

            foreach (int id in CategoryId)
            {
                CategoryCourse categoryCourse = new CategoryCourse()
                {
                    CourseId = nCourse.Id,
                    CategoryId = id,
                    Course = nCourse,

                };
                categoryCourses.Add(categoryCourse);
                await _context.CategoryCourses.AddAsync(categoryCourse);
            }

            if (TagId.Count == 0)
            {
                ModelState.AddModelError("", "Tag bosh ola bilmez");
                return View();
            }

            foreach (int id in TagId)
            {
                CourseTag courseTag = new CourseTag()
                {
                    CourseId = nCourse.Id,
                    TagId = id,
                    Course = nCourse,
                };
                tagCourses.Add(courseTag);
                await _context.CourseTags.AddAsync(courseTag);
            }
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

        public IActionResult Update(int? id)
        {
            Course course = _context.Courses.Where(cr => cr.HasDeleted == false)
                .Include(cr => cr.CourseDetail).FirstOrDefault(cr => cr.Id == id);
            return View(course);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Course course)
        {
            if (id == null) return NotFound();

            Course oldCourse = await _context.Courses.Include(c => c.CourseDetail).FirstOrDefaultAsync(c => c.Id == id);

            Course isExist =await _context.Courses.Where(cr => cr.HasDeleted == false).FirstOrDefaultAsync(cr => cr.Id == id);

            if (isExist != null)
            {
                if (isExist.Id != oldCourse.Id)
                {
                    ModelState.AddModelError("", "Bele bir kurs artiq movcuddur .");
                    return View();
                }
            }

            if (course == null) return NotFound();
            if (course.Photo != null)
            {
                if (!course.Photo.IsImage())
                {
                    ModelState.AddModelError("Photos", $"{course.Photo.FileName} - shekil tipi deyil");
                    return View(oldCourse);
                }

                string folder = Path.Combine("assets","img","course");
                string fileName =await course.Photo.SaveImgAsync(_env.WebRootPath, folder);
                if (fileName == null)
                {
                    return NotFound();
                }

                Helper.DeleteImage(_env.WebRootPath, folder, oldCourse.Image);
                oldCourse.Image = fileName;
            }

            oldCourse.Name = course.Name;
            oldCourse.Description = course.Description;
            oldCourse.CourseDetail.About = course.CourseDetail.About;
            oldCourse.CourseDetail.AboutApply = course.CourseDetail.AboutApply;
            oldCourse.CourseDetail.AboutCertification = course.CourseDetail.AboutCertification;
            oldCourse.CourseDetail.Duration = course.CourseDetail.Duration;
            oldCourse.CourseDetail.ClassDuration = course.CourseDetail.ClassDuration;
            oldCourse.CourseDetail.SkillLevel = course.CourseDetail.SkillLevel;
            oldCourse.CourseDetail.Language = course.CourseDetail.Language;
            oldCourse.CourseDetail.StudentsCount = course.CourseDetail.StudentsCount;
            oldCourse.CourseDetail.StudentsPerGroup = course.CourseDetail.StudentsPerGroup;
            oldCourse.CourseDetail.Price = course.CourseDetail.Price;


            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Course course = await _context.Courses.FindAsync(id);
            if (course == null) return NotFound();
            return View(course);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteEvent(int? id)
        {
            if (id == null) return NotFound();
            Course course = _context.Courses.FirstOrDefault(c => c.Id == id);
            if (course == null) return NotFound();

            if (!course.HasDeleted)
            {
                course.HasDeleted = true;
                //course.CourseDetail.HasDeleted = true;
                course.DeletedTime = DateTime.Now;
                //course.CourseDetail.DeletedTime = DateTime.Now;
            }
            else
                course.HasDeleted = false;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
