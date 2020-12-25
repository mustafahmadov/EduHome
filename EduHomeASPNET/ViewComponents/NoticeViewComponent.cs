using EduHomeASPNET.DAL;
using EduHomeASPNET.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.ViewComponents
{
    public class NoticeViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public NoticeViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int take)
        {
            List<Notice> notices = _context.LeftNotices.Where(n=>n.HasDeleted==false).Take(take).ToList();
            return View(await Task.FromResult(notices));
        }
    }
}
