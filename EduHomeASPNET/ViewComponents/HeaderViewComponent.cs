using EduHomeASPNET.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public HeaderViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(string bannerTitle)
        {
            ViewBag.Title = bannerTitle;
            return View(await Task.FromResult(_context.Bios.FirstOrDefault()));
        }
    }
}
