using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHomeASPNET.DAL;
using EduHomeASPNET.Models;
using EduHomeASPNET.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EduHomeASPNET.Controllers
{
    [Area("Administrator")]
    [Authorize(Policy = "RequireAdministratorRole")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _context;
        public UserController(UserManager<AppUser> userManager,
                               AppDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.currentUserId = _userManager.GetUserId(HttpContext.User);
            List<AppUser> users = _userManager.Users.ToList();
            List<UserVM> usersVM = new List<UserVM>();
            List<string> roles = new List<string> { "Admin", "Member" };
            foreach (AppUser user in users)
            {
                UserVM userVM = new UserVM()
                {
                    Id = user.Id,
                    Fullname = user.Fullname,
                    Email = user.Email,
                    Username = user.UserName,
                    Status = user.HasDeleted,
                    Role = (await _userManager.GetRolesAsync(user))[0],
                };
                usersVM.Add(userVM);
            }
            return View(usersVM);
        }
        public async Task<IActionResult> ChangeStatus(string id)
        {
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            return View(user);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("ChangeStatus")]
        public async Task<IActionResult> ChangeStatusPost(string id)
        {

            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            if (user.HasDeleted)
                user.HasDeleted = false;
            else
                user.HasDeleted = true;
            await _userManager.UpdateAsync(user);
            //await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult ResetPassword()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(string id, ResetPasswordVM reset)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            string token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, token, reset.Password);
            if (result.Succeeded)
            {
                return Content("succeed");
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private async Task<UserVM> GetUserVMAsync(AppUser user)
        {
            List<string> roles = new List<string> { "Admin", "Member" };
            UserVM userVM = new UserVM
            {
                Id = user.Id,
                Email = user.Email,
                Username = user.UserName,
                Fullname = user.Fullname,
                Status = user.HasDeleted,
                Role = (await _userManager.GetRolesAsync(user))[0],
                Roles = roles,
            };
            return userVM;
        }
    }
}
