using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EduHomeASPNET.DAL;
using EduHomeASPNET.Models;
using FrontToUp.Extentions;
using FrontToUp.Helpers;
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
            Blog blog = await _context.Blogs.Include(c => c.BlogDetail).Include(b=>b.Author).FirstOrDefaultAsync(c => c.Id == id);
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
        public async Task<IActionResult> Create(Blog blog,int? AuthorId, List<int> TagId)
        {
            ViewBag.Tags = _context.Tags.Where(t => t.HasDeleted == false).ToList();
            ViewBag.Authors = _context.Authors.ToList();
            Blog newBlog = new Blog();
            BlogDetail newBlogDetail = new BlogDetail();
            if (blog.Photo == null)
            {
                ModelState.AddModelError("Photo", "Shekil bolmesi bosh qala bilmez!");
                return View();
            }

            if (!blog.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa shekil formati sechin");
                return View();
            }

            if (blog.Photo.MaxLength(200))
            {
                ModelState.AddModelError("Photo", "Sheklin maksimum olcusu 200 kb ola biler");
                return View();
            }

            string folder = Path.Combine("assets", "img", "blog");
            string fileName = await blog.Photo.SaveImgAsync(_env.WebRootPath, folder);

            

            List<BlogTag> BlogTags = new List<BlogTag>();
            
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
            newBlog.AuthorId = (int)AuthorId;
            //newBlog.AuthorId = blog.Author.Id;
            newBlog.Image = fileName;
            newBlog.Description = blog.Description;
            newBlog.CommentsCount = 0;
            newBlog.PostedTime = DateTime.UtcNow;
            newBlog.BlogDetailId = newBlogDetail.Id;

            await _context.Blogs.AddAsync(newBlog);
            await _context.SaveChangesAsync();

            newBlogDetail.HasDeleted = false;
            newBlogDetail.FirstContent = blog.BlogDetail.FirstContent;
            newBlogDetail.SecondContent = blog.BlogDetail.SecondContent;
            newBlogDetail.ThirdContent = blog.BlogDetail.ThirdContent;
            newBlogDetail.FourthContent = blog.BlogDetail.FourthContent;
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
            ViewBag.Authors = _context.Authors.ToList();
            Blog blog = _context.Blogs.Where(cr => cr.HasDeleted == false)
                .Include(cr => cr.BlogDetail).FirstOrDefault(cr => cr.Id == id);
            return View(blog);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Blog blog,int? AuthorId)
        {
            ViewBag.Authors = _context.Authors.ToList();
            if (id == null) return NotFound();

            Blog oldBlog = await _context.Blogs.Include(c => c.BlogDetail)
                 .Include(b=>b.Author).FirstOrDefaultAsync(c => c.Id == id);

            Blog isExist = await _context.Blogs.Where(cr => cr.HasDeleted == false).FirstOrDefaultAsync(cr => cr.Id == id);

            if (isExist != null)
            {
                if (isExist.Id != oldBlog.Id)
                {
                    ModelState.AddModelError("", "Bele bir kurs artiq movcuddur .");
                    return View();
                }
            }

            if (blog == null) return NotFound();
            if (blog.Photo != null)
            {
                if (!blog.Photo.IsImage())
                {
                    ModelState.AddModelError("Photos", $"{blog.Photo.FileName} - shekil tipi deyil");
                    return View(oldBlog);
                }

                string folder = Path.Combine("assets", "img", "blog");
                string fileName = await blog.Photo.SaveImgAsync(_env.WebRootPath, folder);
                if (fileName == null)
                {
                    return NotFound();
                }

                Helper.DeleteImage(_env.WebRootPath, folder, oldBlog.Image);
                oldBlog.Image = fileName;
            }
            oldBlog.AuthorId = (int)AuthorId;
            oldBlog.Description = blog.Description;
            oldBlog.BlogDetail.FirstContent = blog.BlogDetail.FirstContent;
            oldBlog.BlogDetail.SecondContent = blog.BlogDetail.SecondContent;
            oldBlog.BlogDetail.ThirdContent = blog.BlogDetail.ThirdContent;
            oldBlog.BlogDetail.FourthContent = blog.BlogDetail.FourthContent;


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
