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
        public IActionResult Index()
        {
            TempData["controllerName"] = this.ControllerContext.RouteData.Values["controller"].ToString();
            List<Event> events = _context.Events.Include(e => e.EventDetail)
                                                   .Where(e => e.HasDeleted == false).ToList();
            return View(events);
        }
        public async Task<IActionResult> EventDetail(int? id)
        {
            TempData["controllerName"] = this.ControllerContext.RouteData.Values["controller"].ToString();
            if (id == null) return NotFound();
            EventVM eventVM = new EventVM()
            {
                Event = await _context.Events.Include(e => e.EventDetail).Where(e => e.HasDeleted == false && e.Id == id).FirstOrDefaultAsync(),
                Speakers = _context.Speakers.ToList(),
                SpeakerEvents = _context.SpeakerEvents.Include(se=>se.Speaker).Where(se=>se.EventId==id).ToList()
            };
           
            return View(eventVM);
        }
    }
}
