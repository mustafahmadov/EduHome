using EduHomeASPNET.DAL;
using EduHomeASPNET.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.ViewComponents
{
    public class TeacherViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public TeacherViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int take)
        {
            List<Teacher> teachers = _context.Teachers.Where(t => t.HasDeleted == false).Take(take).ToList();
            return View(await Task.FromResult(teachers));
        }
    }
}
