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
    public class ChoosesController : Controller
    {
        private readonly AppDbContext _context;

        public ChoosesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Administrator/Chooses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Chooses.ToListAsync());
        }

        // GET: Administrator/Chooses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var choose = await _context.Chooses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (choose == null)
            {
                return NotFound();
            }

            return View(choose);
        }

        // GET: Administrator/Chooses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Administrator/Chooses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,FirstContent,SecondContent")] Choose choose)
        {
            if (ModelState.IsValid)
            {
                _context.Add(choose);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(choose);
        }

        // GET: Administrator/Chooses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var choose = await _context.Chooses.FindAsync(id);
            if (choose == null)
            {
                return NotFound();
            }
            return View(choose);
        }

        // POST: Administrator/Chooses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,FirstContent,SecondContent")] Choose choose)
        {
            if (id != choose.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(choose);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChooseExists(choose.Id))
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
            return View(choose);
        }

        // GET: Administrator/Chooses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var choose = await _context.Chooses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (choose == null)
            {
                return NotFound();
            }

            return View(choose);
        }

        // POST: Administrator/Chooses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var choose = await _context.Chooses.FindAsync(id);
            _context.Chooses.Remove(choose);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChooseExists(int id)
        {
            return _context.Chooses.Any(e => e.Id == id);
        }
    }
}
