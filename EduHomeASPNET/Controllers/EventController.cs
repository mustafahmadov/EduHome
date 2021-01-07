using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHomeASPNET.DAL;
using EduHomeASPNET.Models;
using EduHomeASPNET.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHomeASPNET.Controllers
{

    public class EventController : Controller
    {
        private readonly AppDbContext _context;
        public EventController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? page,int? categoryId)
        {
            TempData["controllerName"] = this.ControllerContext.RouteData.Values["controller"].ToString();
            ViewBag.CatId = categoryId;
            if (categoryId == null)
            {
                ViewBag.PageCount = Decimal.Ceiling((decimal)_context.Courses
                                          .Where(b => b.HasDeleted == false).Count() / 6);
                ViewBag.Page = page;
            }
            List<CategoryEvent> categoryEvents = _context.CategoryEvents.Include(c => c.Event)
                        .Include(e => e.Category).Where(e => e.CategoryId == categoryId && e.Event.HasDeleted == false).ToList();
            return View(categoryEvents);
        } 
        public IActionResult EventDetail(int? id)
        {
            TempData["controllerName"] = this.ControllerContext.RouteData.Values["controller"].ToString();
            if (id == null) return NotFound();
            EventVM eventVM = new EventVM()
            {
                Event = _context.Events.Include(e=>e.EventDetail).Include(e => e.SpeakerEvents)
                                                      .ThenInclude(e => e.Speaker).FirstOrDefault(e=>e.Id==id),
                Speakers = _context.Speakers.ToList(),
            };
            return View(eventVM);
        }

        public IActionResult Search(string search)
        {
            IEnumerable<Event> model = _context.Events.Where(t => t.Name.Contains(search)&&t.HasDeleted==false).Take(6);
            return PartialView("_SearchEventPartial", model);
        }
    }
}
