using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using EduHomeASPNET.Models;
using EduHomeASPNET.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EduHomeASPNET.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]

    public class AdministratorController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public AdministratorController(RoleManager<IdentityRole> roleManager,
                                       UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        #region CreateRole
        [Authorize(Policy = "CreateRolePolicy")]
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        [Authorize(Policy = "CreateRolePolicy")]

        public async Task<IActionResult> CreateRole(CreateRoleVM model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole()
                {
                    Name = model.RoleName,
                };
                IdentityResult result = await _roleManager.CreateAsync(identityRole);
                if (result.Succeeded)
                {
                    return Content("Role Created");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }
        #endregion

        #region GetListOfRoles
        [HttpGet]
        public IActionResult ListRoles()
        {
            var roles = _roleManager.Roles;
            return View(roles);
        }

        #endregion

        #region GetListOfUsers
        public IActionResult ListUsers()
        {
            var users = _userManager.Users;
            return View(users);
        }
        #endregion

        #region EditRole
        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            IdentityRole role = await _roleManager.FindByIdAsync(id);

            if (role == null) return NotFound();

            EditRoleVM model = new EditRoleVM
            {
                Id = role.Id,
                RoleName = role.Name
            };

            foreach (AppUser user in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(user, role.Name))
                    model.Users.Add(user.UserName);
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditRole(EditRoleVM model)
        {
            var role = await _roleManager.FindByIdAsync(model.Id);

            if (role == null) return NotFound();
            else
            {
                role.Name = model.RoleName;

                IdentityResult result = await _roleManager.UpdateAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
 
                return View(model);
            }
        }
        #endregion

        #region EditUsersInRole
        [HttpGet]
        public async Task<IActionResult> EditUsersInRole(string roleId)
        {
            ViewBag.roleId = roleId;
            IdentityRole role = await _roleManager.FindByIdAsync(roleId);

            if (role == null) return NotFound();

            List<UserRoleVM> model = new List<UserRoleVM>();

            foreach (AppUser user in _userManager.Users)
            {
                UserRoleVM userRoleViewModel = new UserRoleVM()
                {
                    UserId = user.Id,
                    UserName = user.UserName
                };

                if (await _userManager.IsInRoleAsync(user, role.Name))
                    userRoleViewModel.IsSelected = true;
                else
                    userRoleViewModel.IsSelected = false;

                model.Add(userRoleViewModel);
            }
            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> EditUsersInRole(List<UserRoleVM> model, string roleId)
        {
            IdentityRole role = await _roleManager.FindByIdAsync(roleId);

            if (role == null) return NotFound();

            for (int i = 0; i < model.Count; i++)
            {
                var user = await _userManager.FindByIdAsync(model[i].UserId);

                IdentityResult result = null;

                if (model[i].IsSelected && !(await _userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await _userManager.AddToRoleAsync(user, role.Name);
                }
                else if (!model[i].IsSelected && await _userManager.IsInRoleAsync(user, role.Name))
                {
                    result = await _userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }

                if (result.Succeeded)
                {
                    if (i < (model.Count - 1))
                        continue;
                    else
                        return RedirectToAction("EditRole", new { Id = roleId });
                }
            }

            return RedirectToAction("EditRole", new { Id = roleId });
        }
        #endregion

        #region EditUser
        [HttpGet]
        public async Task<IActionResult> EditUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }

            var userClaims = await _userManager.GetClaimsAsync(user);
            var userRoles = await _userManager.GetRolesAsync(user);

            var model = new EditUserVM
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                Claims = userClaims.Select(c => c.Value).ToList(),
                Roles = userRoles
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(EditUserVM model)
        {
            var user = await _userManager.FindByIdAsync(model.Id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {model.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                user.Email = model.Email;
                user.UserName = model.UserName;

                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListUsers");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(model);
            }


        }
        #endregion

        #region DeleteUser
        public async Task<IActionResult> Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteUser(string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);

            if (user == null) return NotFound();
            else
            {
                IdentityResult result = await _userManager.DeleteAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListUsers");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View("ListUsers");
            }
        }
        #endregion

        #region ManageUserRoles
        [HttpGet]
        public async Task<IActionResult> ManageUserRoles(string userId)
        {
            ViewBag.userId = userId;

            var user = await _userManager.FindByIdAsync(userId);

            if (user == null) return NotFound();

            List<UserRolesVM> model = new List<UserRolesVM>();

            foreach (IdentityRole role in _roleManager.Roles)
            {
                UserRolesVM userRolesViewModel = new UserRolesVM
                {
                    RoleId = role.Id,
                    RoleName = role.Name
                };

                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    userRolesViewModel.IsSelected = true;
                }
                else
                {
                    userRolesViewModel.IsSelected = false;
                }

                model.Add(userRolesViewModel);
            }

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ManageUserRoles(List<UserRolesVM> model, string userId)
        {
            AppUser user = await _userManager.FindByIdAsync(userId);

            if (user == null) return NotFound();

            var roles = await _userManager.GetRolesAsync(user);
            var result = await _userManager.RemoveFromRolesAsync(user, roles);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot remove user existing roles");
                return View(model);
            }

            result = await _userManager.AddToRolesAsync(user,
                model.Where(x => x.IsSelected).Select(y => y.RoleName));

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot add selected roles to user");
                return View(model);
            }

            return RedirectToAction("EditUser", new { Id = userId });
        }
        #endregion

        #region ManageUserClaims
        [HttpGet]
        public async Task<IActionResult> ManageUserClaims(string userId)
        {
            AppUser user = await _userManager.FindByIdAsync(userId);

            if (user == null) return NotFound();

            var existingUserClaims = await _userManager.GetClaimsAsync(user);

            var model = new UserClaimsVM
            {
                UserId = userId
            };


            foreach (Claim claim in ClaimsStore.AllClaims)
            {
                UserClaim userClaim = new UserClaim
                {
                    ClaimType = claim.Type
                };

                if (existingUserClaims.Any(c => c.Type == claim.Type))
                {
                    userClaim.IsSelected = true;
                }

                model.Cliams.Add(userClaim);
            }

            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> ManageUserClaims(UserClaimsVM model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);

            if (user == null) return NotFound();

            // Get all the user existing claims and delete them
            var claims = await _userManager.GetClaimsAsync(user);
            var result = await _userManager.RemoveClaimsAsync(user, claims);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot remove user existing claims");
                return View(model);
            }

            result = await _userManager.AddClaimsAsync(user,
                model.Cliams.Where(c => c.IsSelected).Select(c => new Claim(c.ClaimType, c.ClaimType)));

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot add selected claims to user");
                return View(model);
            }

            return RedirectToAction("EditUser", new { Id = model.UserId });

        }
        #endregion


    }
}
