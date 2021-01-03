using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using EduHomeASPNET.DAL;
using EduHomeASPNET.Models;
using FrontToUp.Extentions;
using FrontToUp.Helpers;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MimeKit.Text;

namespace EduHomeASPNET.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Policy = "RequireAdministratorRole")]
    public class EventController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        private readonly IConfiguration _config;
        public EventController(AppDbContext context,
                               IWebHostEnvironment env,
                               IConfiguration config)
        {
            _context = context;
            _env = env;
            _config = config;
        }
        // GET: EventController
        public ActionResult Index()
        {
            List<Event> events = _context.Events.Where(c => c.HasDeleted == false)
                .Include(c => c.EventDetail).ToList();
            return View(events);
        }

        //GET: EventController/Details/5
        public async Task<ActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Event eve = await _context.Events.Include(c => c.EventDetail).FirstOrDefaultAsync(c => c.Id == id);
            if (eve == null) return NotFound();

            return View(eve);
        }

        //GET: EventController/Create
        public IActionResult Create()
        {
            ViewBag.Tags = _context.Tags.Where(t => t.HasDeleted == false).ToList();
            ViewBag.Speakers = _context.Speakers.ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Event eve, List<int> TagId,List<int> SpeakerId)
        {
            ViewBag.Tags = _context.Tags.Where(t => t.HasDeleted == false).ToList();
            ViewBag.Speakers = _context.Speakers.ToList();
            Event newEvent = new Event();
            EventDetail newEventDetail = new EventDetail();
            if (eve.Photo == null)
            {
                ModelState.AddModelError("Photo", "Shekil bolmesi bosh qala bilmez!");
                return View();
            }
            if (eve.Name == null)
            {
                ModelState.AddModelError("Name", "Zehmet olmasa kursunuzun adini daxil edin");
                return View();
            }
            if (eve.PlacedArea == null)
            {
                ModelState.AddModelError("PlacedArea", " Mekani daxil edin");
                return View();
            }
            if (eve.EventDetail.DetailedPlacedArea == null)
            {
                ModelState.AddModelError("DetailedPlacedArea", "Detalli mekani daxil edin");
                return View();
            }

            if (!eve.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa shekil formati sechin");
                return View();
            }

            if (eve.Photo.MaxLength(200))
            {
                ModelState.AddModelError("Photo", "Sheklin maksimum olcusu 200 kb ola biler");
                return View();
            }

            string folder = Path.Combine("assets", "img", "event");
            string fileName = await eve.Photo.SaveImgAsync(_env.WebRootPath, folder);

            List<EventTag> eventTags = new List<EventTag>();
            List<SpeakerEvent> speakerEvents = new List<SpeakerEvent>();

            if (TagId.Count == 0)
            {
                ModelState.AddModelError("", "Tag bosh ola bilmez");
                return View();
            }

            foreach (int id in TagId)
            {
                EventTag eventTag = new EventTag()
                {
                    EventId = newEvent.Id,
                    TagId = id,
                    Event = newEvent
                };
                eventTags.Add(eventTag);
                await _context.EventTags.AddAsync(eventTag);
            }
            if (SpeakerId.Count == 0)
            {
                ModelState.AddModelError("", "Speaker bosh ola bilmez");
                return View();
            }

            foreach (int id in SpeakerId)
            {
                SpeakerEvent speakerEvent = new SpeakerEvent()
                {
                    EventId = newEvent.Id,
                    SpeakerId = id,
                    Event = newEvent
                };
                speakerEvents.Add(speakerEvent);
                await _context.SpeakerEvents.AddAsync(speakerEvent);
            }
            newEvent.Image = fileName;
            newEvent.Name = eve.Name;
            newEvent.OrganizedDay = eve.OrganizedDay;
            newEvent.HasDeleted = false;
            newEvent.PlacedArea = eve.PlacedArea;
            newEvent.StartTime = eve.StartTime;
            newEvent.EndTime = eve.EndTime;
            newEvent.EventDetailId = newEventDetail.Id;

            await _context.Events.AddAsync(newEvent);
            await _context.SaveChangesAsync();

            newEventDetail.HasDeleted = false;
            newEventDetail.DetailedPlacedArea = eve.EventDetail.DetailedPlacedArea;
            newEventDetail.FirstContent = eve.EventDetail.FirstContent;
            newEventDetail.SecondContent = eve.EventDetail.SecondContent;
            newEventDetail.ThirdContent = eve.EventDetail.ThirdContent;
            newEventDetail.EventId = newEvent.Id;
            newEvent.EventDetailId = newEventDetail.Id;


            await _context.EventDetails.AddAsync(newEventDetail);
            await _context.SaveChangesAsync();

            List<SubscribedEmail> emails = _context.SubscribedEmails.Where(e => e.HasDeleted == false).ToList();
            foreach (SubscribedEmail email in emails)
            {
                await SendEmailAsync(email.Email, "Yeni bir event yaradildi.", "<h1>Yeni bir event yaradildi</h1>");
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: EventController/Edit/5
        public IActionResult Update(int? id)
        {
            Event eve = _context.Events.Where(cr => cr.HasDeleted == false)
                .Include(cr => cr.EventDetail).FirstOrDefault(cr => cr.Id == id);
            return View(eve);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Event eve)
        {
            if (id == null) return NotFound();

            Event oldEvent = await _context.Events.Include(c => c.EventDetail).FirstOrDefaultAsync(c => c.Id == id);

            Event isExist = await _context.Events.Where(cr => cr.HasDeleted == false).FirstOrDefaultAsync(cr => cr.Id == id);

            if (isExist != null)
            {
                if (isExist.Id != oldEvent.Id)
                {
                    ModelState.AddModelError("", "Bele bir kurs artiq movcuddur .");
                    return View();
                }
            }

            if (eve == null) return NotFound();
            if (eve.Photo != null)
            {
                if (!eve.Photo.IsImage())
                {
                    ModelState.AddModelError("Photos", $"{eve.Photo.FileName} - shekil tipi deyil");
                    return View(oldEvent);
                }

                string folder = Path.Combine("assets", "img", "event");
                string fileName = await eve.Photo.SaveImgAsync(_env.WebRootPath, folder);
                if (fileName == null)
                {
                    return NotFound();
                }

                Helper.DeleteImage(_env.WebRootPath, folder, oldEvent.Image);
                oldEvent.Image = fileName;
            }
            oldEvent.Name = eve.Name;
            oldEvent.OrganizedDay = eve.OrganizedDay;
            oldEvent.PlacedArea = eve.PlacedArea;
            oldEvent.StartTime = eve.StartTime;
            oldEvent.EndTime = eve.EndTime;
            oldEvent.EventDetail.DetailedPlacedArea = eve.EventDetail.DetailedPlacedArea;
            oldEvent.EventDetail.FirstContent = eve.EventDetail.FirstContent;
            oldEvent.EventDetail.SecondContent = eve.EventDetail.SecondContent;
            oldEvent.EventDetail.ThirdContent = eve.EventDetail.ThirdContent;


            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Event Event = await _context.Events.FindAsync(id);
            if (Event == null) return NotFound();
            return View(Event);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteEvent(int? id)
        {
            if (id == null) return NotFound();
            Event Event = _context.Events.FirstOrDefault(c => c.Id == id);
            if (Event == null) return NotFound();

            if (!Event.HasDeleted)
            {
                Event.HasDeleted = true;
                //Event.EventDetail.HasDeleted = true;
                Event.DeletedTime = DateTime.Now;
                //Event.EventDetail.DeletedTime = DateTime.Now;
            }
            else
                Event.HasDeleted = false;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "mustafaahmadov8@gmail.com",
                    Password = "Araz2006"
                }
            };
            MailAddress fromEmail = new MailAddress("mustafaahmadov8@gmail.com", "Mustafa");
            MailAddress toEmail = new MailAddress(email, "Mustafa");
            MailMessage message = new MailMessage()
            {
                From = fromEmail,
                Subject = subject,
                Body = htmlMessage
            };
            message.To.Add(toEmail);
            client.Send(message);
        }
    }
}
