using EduHomeASPNET.DAL;
using EduHomeASPNET.Models;
using EduHomeASPNET.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.ViewComponents
{
    public class ReplyViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public ReplyViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ReplyVM replyVM = new ReplyVM();
            return View(await Task.FromResult(replyVM));
        }
    }
}
