using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHomeASPNET.DAL;
using EduHomeASPNET.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EduHomeASPNET.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext context;

        public ContactController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            TempData["controllerName"] = this.ControllerContext.RouteData.Values["controller"].ToString();
            ContactVM contactVM = new ContactVM()
            {
                Map = context.Maps.FirstOrDefault(),
                ContactDetails = context.ContactDetails.ToList()
            };
            return View(contactVM);
        }
    }
}
