using EduHomeProject.DAL;
using EduHomeProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.ViewComponents
{
    public class TestimonialViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public TestimonialViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<StudentComment> comments = _context.StudentComments.Include(st => st.Student)
                  .Where(st => st.HasDeleted == false).Take(5).ToList();
            return View(await Task.FromResult(comments));
        }
    }
}
