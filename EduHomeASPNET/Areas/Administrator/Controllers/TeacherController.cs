using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EduHomeASPNET.DAL;
using EduHomeASPNET.Models;
using FrontToUp.Extentions;
using FrontToUp.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHomeASPNET.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class TeacherController : Controller
    {

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public TeacherController(AppDbContext context,
                               IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Teacher> teachers = _context.Teachers.Where(c => c.HasDeleted == false)
                .Include(c => c.TeacherDetail).ToList();
            return View(teachers);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Teacher Teacher = await _context.Teachers.Include(c => c.TeacherDetail)
                 .Include(t=>t.Skill).FirstOrDefaultAsync(c => c.Id == id);
            if (Teacher == null) return NotFound();

            return View(Teacher);
        }
        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.Where(c => c.HasDeleted == false).ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Teacher Teacher, List<int> TagId, List<int> CategoryId)
        {
            ViewBag.Categories = _context.Categories.Where(c => c.HasDeleted == false).ToList();
            Teacher nTeacher = new Teacher();
            TeacherDetail nTeacherDetail = new TeacherDetail();
            Skill nSkill = new Skill();
            if (Teacher.Photo == null)
            {
                ModelState.AddModelError("Photo", "Shekil bolmesi bosh qala bilmez!");
                return View();
            }
            if (Teacher.Name == null)
            {
                ModelState.AddModelError("Name", "Zehmet olmasa kursunuzun adini daxil edin");
                return View();
            }
            if (Teacher.Surname == null)
            {
                ModelState.AddModelError("Surname", "Dili daxil edin");
                return View();
            }
            if (Teacher.Age == null)
            {
                ModelState.AddModelError("Age", "Zehmet olmasa qiymeti daxil edin");
                return View();
            }
            if (Teacher.Profession == null)
            {
                ModelState.AddModelError("Profession", "Zehmet olmasa seviyeleri daxil edin");
                return View();
            }

            if (!Teacher.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa shekil formati sechin");
                return View();
            }

            if (Teacher.Photo.MaxLength(200))
            {
                ModelState.AddModelError("Photo", "Sheklin maksimum olcusu 200 kb ola biler");
                return View();
            }

            string folder = Path.Combine("assets", "img", "teacher");
            string fileName = await Teacher.Photo.SaveImgAsync(_env.WebRootPath, folder);

            List<CategoryTeacher> categoryTeachers = new List<CategoryTeacher>();

            if (CategoryId.Count == 0)
            {
                ModelState.AddModelError("", "Kategoriya bosh ola bilmez");
                return View();
            }

            foreach (int id in CategoryId)
            {
                CategoryTeacher categoryTeacher = new CategoryTeacher()
                {
                    TeacherId = nTeacher.Id,
                    CategoryId = id,
                    Teacher = nTeacher,

                };
                categoryTeachers.Add(categoryTeacher);
                await _context.CategoryTeachers.AddAsync(categoryTeacher);
            }

            nTeacher.Image = fileName;
            nTeacher.Name = Teacher.Name;
            nTeacher.Surname = Teacher.Surname;
            nTeacher.Age = Teacher.Age;
            nTeacher.Profession = Teacher.Profession;
            nTeacher.Twitter = Teacher.Twitter;
            nTeacher.Facebook = Teacher.Facebook;
            nTeacher.Email = Teacher.Email;
            nTeacher.Phone = Teacher.Phone;
            nTeacher.Pinterest = Teacher.Pinterest;
            nTeacher.Vimeo = Teacher.Vimeo;
            nTeacher.HasDeleted = false;
            
            

            await _context.Teachers.AddAsync(nTeacher);
            await _context.SaveChangesAsync();
            nTeacherDetail.Hobbies = Teacher.TeacherDetail.Hobbies;
            nTeacherDetail.Degree = Teacher.TeacherDetail.Degree;
            nTeacherDetail.Faculty = Teacher.TeacherDetail.Faculty;
            nTeacherDetail.Experience = Teacher.TeacherDetail.Experience;
            
            nTeacherDetail.TeacherId = nTeacher.Id;
            nTeacher.TeacherDetailId = nTeacherDetail.Id;

            nSkill.Communication = Teacher.Skill.Communication;
            nSkill.Innovation = Teacher.Skill.Innovation;
            nSkill.Design = Teacher.Skill.Design;
            nSkill.Development = Teacher.Skill.Development;
            nSkill.Language = Teacher.Skill.Language;
            nSkill.TeamLeader = Teacher.Skill.TeamLeader;

            nSkill.TeacherId = nTeacher.Id;
            nTeacher.SkillId = nSkill.Id;

            await _context.AddAsync(nTeacherDetail);
            await _context.AddAsync(nSkill);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int? id)
        {
            Teacher Teacher = _context.Teachers.Where(cr => cr.HasDeleted == false)
                .Include(cr => cr.TeacherDetail).Include(t=>t.Skill).FirstOrDefault(cr => cr.Id == id);
            return View(Teacher);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Teacher Teacher)
        {
            if (id == null) return NotFound();

            Teacher oldTeacher = await _context.Teachers.Include(c => c.TeacherDetail)
                                     .Include(t=>t.Skill).FirstOrDefaultAsync(c => c.Id == id);

            Teacher isExist = await _context.Teachers.Where(cr => cr.HasDeleted == false).FirstOrDefaultAsync(cr => cr.Id == id);

            if (isExist != null)
            {
                if (isExist.Id != oldTeacher.Id)
                {
                    ModelState.AddModelError("", "Bele bir mellim artiq movcuddur .");
                    return View();
                }
            }

            if (Teacher == null) return NotFound();
            if (Teacher.Photo != null)
            {
                if (!Teacher.Photo.IsImage())
                {
                    ModelState.AddModelError("Photos", $"{Teacher.Photo.FileName} - shekil tipi deyil");
                    return View(oldTeacher);
                }

                string folder = Path.Combine("assets", "img", "teacher");
                string fileName = await Teacher.Photo.SaveImgAsync(_env.WebRootPath, folder);
                if (fileName == null)
                {
                    return NotFound();
                }

                Helper.DeleteImage(_env.WebRootPath, folder, oldTeacher.Image);
                oldTeacher.Image = fileName;
            }

            oldTeacher.Name = Teacher.Name;
            oldTeacher.Surname = Teacher.Surname;
            oldTeacher.Age = Teacher.Age;
            oldTeacher.Profession = Teacher.Profession;
            oldTeacher.Twitter = Teacher.Twitter;
            oldTeacher.Facebook = Teacher.Facebook;
            oldTeacher.Email = Teacher.Email;
            oldTeacher.Phone = Teacher.Phone;
            oldTeacher.Pinterest = Teacher.Pinterest;
            oldTeacher.Vimeo = Teacher.Vimeo;

            oldTeacher.TeacherDetail.Hobbies = Teacher.TeacherDetail.Hobbies;
            oldTeacher.TeacherDetail.Degree = Teacher.TeacherDetail.Degree;
            oldTeacher.TeacherDetail.Faculty = Teacher.TeacherDetail.Faculty;
            oldTeacher.TeacherDetail.Experience = Teacher.TeacherDetail.Experience;

            oldTeacher.Skill.Communication = Teacher.Skill.Communication;
            oldTeacher.Skill.Innovation = Teacher.Skill.Innovation;
            oldTeacher.Skill.Design = Teacher.Skill.Design;
            oldTeacher.Skill.Development = Teacher.Skill.Development;
            oldTeacher.Skill.Language = Teacher.Skill.Language;
            oldTeacher.Skill.TeamLeader = Teacher.Skill.TeamLeader;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Teacher Teacher = await _context.Teachers.FindAsync(id);
            if (Teacher == null) return NotFound();
            return View(Teacher);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteEvent(int? id)
        {
            if (id == null) return NotFound();
            Teacher Teacher = _context.Teachers.FirstOrDefault(c => c.Id == id);
            if (Teacher == null) return NotFound();

            if (!Teacher.HasDeleted)
            {
                Teacher.HasDeleted = true;
                //Teacher.TeacherDetail.HasDeleted = true;
                Teacher.DeletedTime = DateTime.Now;
                //Teacher.TeacherDetail.DeletedTime = DateTime.Now;
            }
            else
                Teacher.HasDeleted = false;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
