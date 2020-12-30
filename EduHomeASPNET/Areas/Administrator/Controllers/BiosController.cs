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
    public class BiosController : Controller
    {
        private readonly AppDbContext _context;

        public BiosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Administrator/Bios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bios.ToListAsync());
        }

        // GET: Administrator/Bios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bio = await _context.Bios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bio == null)
            {
                return NotFound();
            }

            return View(bio);
        }

        // GET: Administrator/Bios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Administrator/Bios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Logo,Description,Facebook,Pinterest,Vimeo,Twitter,Address,Phone,Email")] Bio bio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bio);
        }

        // GET: Administrator/Bios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bio = await _context.Bios.FindAsync(id);
            if (bio == null)
            {
                return NotFound();
            }
            return View(bio);
        }

        // POST: Administrator/Bios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Description,Facebook,Pinterest,Vimeo,Twitter,Address,Phone,Email")] Bio bio)
        {
            if (id != bio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BioExists(bio.Id))
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
            return View(bio);
        }

        // GET: Administrator/Bios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bio = await _context.Bios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bio == null)
            {
                return NotFound();
            }

            return View(bio);
        }

        // POST: Administrator/Bios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bio = await _context.Bios.FindAsync(id);
            _context.Bios.Remove(bio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BioExists(int id)
        {
            return _context.Bios.Any(e => e.Id == id);
        }
    }
}
