using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EduHomeASPNET.DAL;
using EduHomeASPNET.Models;
using Microsoft.AspNetCore.Authorization;

namespace EduHomeASPNET.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Policy = "RequireAdministratorRole")]
    public class SubscribesController : Controller
    {
        private readonly AppDbContext _context;

        public SubscribesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Administrator/Subscribes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Subscribes.ToListAsync());
        }

        // GET: Administrator/Subscribes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscribe = await _context.Subscribes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subscribe == null)
            {
                return NotFound();
            }

            return View(subscribe);
        }

        // GET: Administrator/Subscribes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Administrator/Subscribes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description")] Subscribe subscribe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subscribe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(subscribe);
        }

        // GET: Administrator/Subscribes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscribe = await _context.Subscribes.FindAsync(id);
            if (subscribe == null)
            {
                return NotFound();
            }
            return View(subscribe);
        }

        // POST: Administrator/Subscribes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description")] Subscribe subscribe)
        {
            if (id != subscribe.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subscribe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubscribeExists(subscribe.Id))
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
            return View(subscribe);
        }

        // GET: Administrator/Subscribes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscribe = await _context.Subscribes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subscribe == null)
            {
                return NotFound();
            }

            return View(subscribe);
        }

        // POST: Administrator/Subscribes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subscribe = await _context.Subscribes.FindAsync(id);
            _context.Subscribes.Remove(subscribe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubscribeExists(int id)
        {
            return _context.Subscribes.Any(e => e.Id == id);
        }
    }
}
