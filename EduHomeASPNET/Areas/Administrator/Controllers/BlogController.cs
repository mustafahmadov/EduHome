using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHomeASPNET.DAL;
using EduHomeASPNET.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHomeASPNET.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public BlogController(AppDbContext context,
                               IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        // GET: BlogController
        public ActionResult Index()
        {
            List<Blog> Blogs = _context.Blogs.Where(c => c.HasDeleted == false)
                .Include(c => c.BlogDetail).ToList();
            return View(Blogs);
        }

        //GET: BlogController/Details/5
        public async Task<ActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Blog blog = await _context.Blogs.Include(c => c.BlogDetail).FirstOrDefaultAsync(c => c.Id == id);
            if (blog == null) return NotFound();

            return View(blog);
        }

        //GET: BlogController/Create
        public IActionResult Create()
        {
            ViewBag.Tags = _context.Tags.Where(t => t.HasDeleted == false).ToList();
            ViewBag.Authors = _context.Authors.ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog eve, List<int> TagId, List<int> SpeakerId)
        {
            ViewBag.Tags = _context.Tags.Where(t => t.HasDeleted == false).ToList();
            ViewBag.Speakers = _context.Speakers.ToList();
            Blog newBlog = new Blog();
            BlogDetail newBlogDetail = new BlogDetail();
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
            if (eve.BlogDetail.DetailedPlacedArea == null)
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

            string folder = Path.Combine("assets", "img", "Blog");
            string fileName = await eve.Photo.SaveImgAsync(_env.WebRootPath, folder);

            List<BlogTag> BlogTags = new List<BlogTag>();
            List<SpeakerBlog> speakerBlogs = new List<SpeakerBlog>();

            if (TagId.Count == 0)
            {
                ModelState.AddModelError("", "Tag bosh ola bilmez");
                return View();
            }

            foreach (int id in TagId)
            {
                BlogTag BlogTag = new BlogTag()
                {
                    BlogId = newBlog.Id,
                    TagId = id,
                    Blog = newBlog
                };
                BlogTags.Add(BlogTag);
                await _context.BlogTags.AddAsync(BlogTag);
            }
            if (SpeakerId.Count == 0)
            {
                ModelState.AddModelError("", "Speaker bosh ola bilmez");
                return View();
            }

            foreach (int id in SpeakerId)
            {
                SpeakerBlog speakerBlog = new SpeakerBlog()
                {
                    BlogId = newBlog.Id,
                    SpeakerId = id,
                    Blog = newBlog
                };
                speakerBlogs.Add(speakerBlog);
                await _context.SpeakerBlogs.AddAsync(speakerBlog);
            }
            newBlog.Image = fileName;
            newBlog.Name = eve.Name;
            newBlog.OrganizedDay = eve.OrganizedDay;
            newBlog.HasDeleted = false;
            newBlog.PlacedArea = eve.PlacedArea;
            newBlog.StartTime = eve.StartTime;
            newBlog.EndTime = eve.EndTime;
            newBlog.BlogDetailId = newBlogDetail.Id;

            await _context.Blogs.AddAsync(newBlog);
            await _context.SaveChangesAsync();

            newBlogDetail.HasDeleted = false;
            newBlogDetail.DetailedPlacedArea = eve.BlogDetail.DetailedPlacedArea;
            newBlogDetail.FirstContent = eve.BlogDetail.FirstContent;
            newBlogDetail.SecondContent = eve.BlogDetail.SecondContent;
            newBlogDetail.ThirdContent = eve.BlogDetail.ThirdContent;
            newBlogDetail.BlogId = newBlog.Id;
            newBlog.BlogDetailId = newBlogDetail.Id;


            await _context.BlogDetails.AddAsync(newBlogDetail);
            newBlog.BlogDetailId = newBlogDetail.Id;
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // GET: BlogController/Edit/5
        public IActionResult Update(int? id)
        {
            Blog eve = _context.Blogs.Where(cr => cr.HasDeleted == false)
                .Include(cr => cr.BlogDetail).FirstOrDefault(cr => cr.Id == id);
            return View(eve);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Blog eve)
        {
            if (id == null) return NotFound();

            Blog oldBlog = await _context.Blogs.Include(c => c.BlogDetail).FirstOrDefaultAsync(c => c.Id == id);

            Blog isExist = await _context.Blogs.Where(cr => cr.HasDeleted == false).FirstOrDefaultAsync(cr => cr.Id == id);

            if (isExist != null)
            {
                if (isExist.Id != oldBlog.Id)
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
                    return View(oldBlog);
                }

                string folder = Path.Combine("assets", "img", "Blog");
                string fileName = await eve.Photo.SaveImgAsync(_env.WebRootPath, folder);
                if (fileName == null)
                {
                    return NotFound();
                }

                Helper.DeleteImage(_env.WebRootPath, folder, oldBlog.Image);
                oldBlog.Image = fileName;
            }
            oldBlog.Name = eve.Name;
            oldBlog.OrganizedDay = eve.OrganizedDay;
            oldBlog.PlacedArea = eve.PlacedArea;
            oldBlog.StartTime = eve.StartTime;
            oldBlog.EndTime = eve.EndTime;
            oldBlog.BlogDetail.DetailedPlacedArea = eve.BlogDetail.DetailedPlacedArea;
            oldBlog.BlogDetail.FirstContent = eve.BlogDetail.FirstContent;
            oldBlog.BlogDetail.SecondContent = eve.BlogDetail.SecondContent;
            oldBlog.BlogDetail.ThirdContent = eve.BlogDetail.ThirdContent;


            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Blog Blog = await _context.Blogs.FindAsync(id);
            if (Blog == null) return NotFound();
            return View(Blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteBlog(int? id)
        {
            if (id == null) return NotFound();
            Blog Blog = _context.Blogs.FirstOrDefault(c => c.Id == id);
            if (Blog == null) return NotFound();

            if (!Blog.HasDeleted)
            {
                Blog.HasDeleted = true;
                //Blog.BlogDetail.HasDeleted = true;
                Blog.DeletedTime = DateTime.Now;
                //Blog.BlogDetail.DeletedTime = DateTime.Now;
            }
            else
                Blog.HasDeleted = false;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
