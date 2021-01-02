using EduHomeASPNET.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.ViewComponents
{
    public class CourseViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public CourseViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int? page,int take = 3)
        {
            ViewBag.PageCount = Decimal.Ceiling((decimal)_context.Courses
                                          .Where(b => b.HasDeleted == false).Count() / (int)take);
            ViewBag.Page = page;
            if (page == null)
            {
                return View(await _context.Courses.Include(teacher => teacher.CourseDetail).Where(b => b.HasDeleted == false)
                                      .OrderByDescending(b => b.Id).Take((int)take).ToListAsync());
            }
            return View(await Task.FromResult(await _context.Courses.Include(teacher => teacher.CourseDetail).Where(b => b.HasDeleted == false)
                                       .OrderByDescending(b => b.Id).Skip(((int)page - 1) * (int)take).Take((int)take).ToListAsync()));
        }
    }
}
