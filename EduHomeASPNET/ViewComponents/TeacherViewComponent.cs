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

        public async Task<IViewComponentResult> InvokeAsync(int? page,int take)
        {
            //List<Teacher> teachers = _context.Teachers.Where(t => t.HasDeleted == false).Take(take).ToList();
            ViewBag.PageCount = Decimal.Ceiling((decimal)_context.Teachers.Where(t => t.HasDeleted == false).Count() / (int)take);
            ViewBag.Page = page;
            if (page == null)
            {
                return View(_context.Teachers.Where(t => t.HasDeleted == false).Take((int)take).ToList());
            }
            return View(await Task.FromResult(_context.Teachers.Where(t => t.HasDeleted == false).Skip(((int)page - 1) * (int)take).Take((int)take).ToList()));
            //return View(await Task.FromResult(teachers));
        }
    }
}
