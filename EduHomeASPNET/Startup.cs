using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHomeASPNET.DAL;
using EduHomeASPNET.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EduHomeASPNET
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddIdentity<AppUser, IdentityRole>(identityOptions =>
            {
                identityOptions.Password.RequiredLength = 8;
                identityOptions.Password.RequireDigit = true;
                identityOptions.Password.RequireUppercase = true;

                identityOptions.User.RequireUniqueEmail = true;
                identityOptions.Lockout.AllowedForNewUsers = true;
                identityOptions.Lockout.MaxFailedAccessAttempts = 3;
                identityOptions.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(Configuration["ConnectionString:Default"]);
            });
            //services.AddMvc(options =>
            //{
            //    var policy = new AuthorizationPolicyBuilder()
            //                    .RequireAuthenticatedUser()
            //                    .Build();
            //    options.Filters.Add(new AuthorizeFilter(policy));
            //});
            services.AddAuthorization(options =>
            {
                options.AddPolicy("RequireAdministratorRole",
                     policy => policy.RequireRole("Admin"));
                options.AddPolicy("CreateCoursePolicy",
                     policy => policy.RequireClaim("Create Course"));
                options.AddPolicy("UpdateCoursePolicy",
                     policy => policy.RequireClaim("Update Course"));
                options.AddPolicy("DetailCoursePolicy",
                     policy => policy.RequireClaim("Detail Course"));
                options.AddPolicy("DeleteCoursePolicy",
                     policy => policy.RequireClaim("Delete Course"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                  );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                  );

            });
        }
    }
}
