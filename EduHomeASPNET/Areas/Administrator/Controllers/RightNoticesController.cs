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
    public class RightNoticesController : Controller
    {
        private readonly AppDbContext _context;

        public RightNoticesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Administrator/RightNotices
        public async Task<IActionResult> Index()
        {
            return View(await _context.RightNotices.ToListAsync());
        }

        // GET: Administrator/RightNotices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rightNotice = await _context.RightNotices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rightNotice == null)
            {
                return NotFound();
            }

            return View(rightNotice);
        }

        // GET: Administrator/RightNotices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Administrator/RightNotices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Content")] RightNotice rightNotice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rightNotice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rightNotice);
        }

        // GET: Administrator/RightNotices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rightNotice = await _context.RightNotices.FindAsync(id);
            if (rightNotice == null)
            {
                return NotFound();
            }
            return View(rightNotice);
        }

        // POST: Administrator/RightNotices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content")] RightNotice rightNotice)
        {
            if (id != rightNotice.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rightNotice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RightNoticeExists(rightNotice.Id))
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
            return View(rightNotice);
        }

        // GET: Administrator/RightNotices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rightNotice = await _context.RightNotices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rightNotice == null)
            {
                return NotFound();
            }

            return View(rightNotice);
        }

        // POST: Administrator/RightNotices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rightNotice = await _context.RightNotices.FindAsync(id);
            _context.RightNotices.Remove(rightNotice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RightNoticeExists(int id)
        {
            return _context.RightNotices.Any(e => e.Id == id);
        }
    }
}
