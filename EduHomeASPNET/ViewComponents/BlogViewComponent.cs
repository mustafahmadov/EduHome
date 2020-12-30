using EduHomeASPNET.DAL;
using EduHomeASPNET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public BlogViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int? page,int take)
        {
            ViewBag.PageCount =  Decimal.Ceiling((decimal)_context.Blogs
                                          .Where(b => b.HasDeleted == false).Count()/(int)take);
            ViewBag.Page = page;
            if (page == null)
            {
                return View(await _context.Blogs.Include(blogs => blogs.Author).Where(b => b.HasDeleted == false)
                                                .OrderByDescending(b => b.Id).Take((int)take).ToListAsync());
            }
            
            return View(await Task.FromResult(await _context.Blogs.Include(blogs => blogs.Author).Where(b => b.HasDeleted == false)
                                          .OrderByDescending(b => b.Id).Skip(((int)page - 1) * (int)take).Take((int)take).ToListAsync()));
        }
    }
}
