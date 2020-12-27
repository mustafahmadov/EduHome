using EduHomeASPNET.DAL;
using EduHomeASPNET.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.ViewComponents
{
    public class SidebarViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public SidebarViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            SidebarVM sidebar = new SidebarVM()
            {
                Blogs = _context.Blogs.Include(b=>b.Author).Where(b => b.HasDeleted == false).OrderByDescending(b => b.Id).Take(3).ToList(),
                Categories = _context.Categories.Where(c => c.HasDeleted == false).Take(6).ToList()
            };
            return View(await Task.FromResult(sidebar));
        }
    }
}
