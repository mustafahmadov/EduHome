using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EduHomeASPNET.DAL;
using EduHomeASPNET.Models;

namespace EduHomeASPNET.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class ContactDetailsController : Controller
    {
        private readonly AppDbContext _context;

        public ContactDetailsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Administrator/ContactDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.ContactDetails.ToListAsync());
        }

        // GET: Administrator/ContactDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactDetail = await _context.ContactDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactDetail == null)
            {
                return NotFound();
            }

            return View(contactDetail);
        }

        // GET: Administrator/ContactDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Administrator/ContactDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Image,Address,Settlement")] ContactDetail contactDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactDetail);
        }

        // GET: Administrator/ContactDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactDetail = await _context.ContactDetails.FindAsync(id);
            if (contactDetail == null)
            {
                return NotFound();
            }
            return View(contactDetail);
        }

        // POST: Administrator/ContactDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Image,Address,Settlement")] ContactDetail contactDetail)
        {
            if (id != contactDetail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactDetailExists(contactDetail.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(contactDetail);
        }

        // GET: Administrator/ContactDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactDetail = await _context.ContactDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactDetail == null)
            {
                return NotFound();
            }

            return View(contactDetail);
        }

        // POST: Administrator/ContactDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contactDetail = await _context.ContactDetails.FindAsync(id);
            _context.ContactDetails.Remove(contactDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactDetailExists(int id)
        {
            return _context.ContactDetails.Any(e => e.Id == id);
        }
    }
}
