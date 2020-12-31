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
    public class BlogDetailsController : Controller
    {
        private readonly AppDbContext _context;

        public BlogDetailsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Administrator/BlogDetails
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.BlogDetails.Include(b => b.Blog);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Administrator/BlogDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogDetail = await _context.BlogDetails
                .Include(b => b.Blog)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogDetail == null)
            {
                return NotFound();
            }

            return View(blogDetail);
        }

        // GET: Administrator/BlogDetails/Create
        public IActionResult Create()
        {
            ViewData["BlogId"] = new SelectList(_context.Blogs, "Id", "Image");
            return View();
        }

        // POST: Administrator/BlogDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DetailedImage,FirstContent,SecondContent,ThirdContent,FourthContent,HasDeleted,DeletedTime,BlogId")] BlogDetail blogDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(blogDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BlogId"] = new SelectList(_context.Blogs, "Id", "Image", blogDetail.BlogId);
            return View(blogDetail);
        }

        // GET: Administrator/BlogDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogDetail = await _context.BlogDetails.FindAsync(id);
            if (blogDetail == null)
            {
                return NotFound();
            }
            ViewData["BlogId"] = new SelectList(_context.Blogs, "Id", "Image", blogDetail.BlogId);
            return View(blogDetail);
        }

        // POST: Administrator/BlogDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DetailedImage,FirstContent,SecondContent,ThirdContent,FourthContent,HasDeleted,DeletedTime,BlogId")] BlogDetail blogDetail)
        {
            if (id != blogDetail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blogDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogDetailExists(blogDetail.Id))
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
            ViewData["BlogId"] = new SelectList(_context.Blogs, "Id", "Image", blogDetail.BlogId);
            return View(blogDetail);
        }

        // GET: Administrator/BlogDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogDetail = await _context.BlogDetails
                .Include(b => b.Blog)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogDetail == null)
            {
                return NotFound();
            }

            return View(blogDetail);
        }

        // POST: Administrator/BlogDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blogDetail = await _context.BlogDetails.FindAsync(id);
            _context.BlogDetails.Remove(blogDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogDetailExists(int id)
        {
            return _context.BlogDetails.Any(e => e.Id == id);
        }
    }
}
