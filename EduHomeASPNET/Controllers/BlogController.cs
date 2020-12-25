using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EduHomeASPNET.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            TempData["controllerName"] = this.ControllerContext.RouteData.Values["controller"].ToString();
            return View();
        }
    }
}
