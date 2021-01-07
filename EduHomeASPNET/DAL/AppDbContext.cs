using EduHomeASPNET.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<Notice> LeftNotices { get; set; }
        public DbSet<RightNotice> RightNotices { get; set; }
        public DbSet<Choose> Chooses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseDetail> CourseDetails { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventDetail> EventDetails { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentComment> StudentComments { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogDetail> BlogDetails { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherDetail> TeacherDetails { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryCourse> CategoryCourses { get; set; }
        public DbSet<CategoryTeacher> CategoryTeachers { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<SpeakerEvent> SpeakerEvents { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<EventTag> EventTags { get; set; }
        public DbSet<CourseTag> CourseTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<SubscribedEmail> SubscribedEmails { get; set; }
        public DbSet<ContactDetail> ContactDetails { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<CategoryBlog> CategoryBlogs { get; set; }
        public DbSet<CategoryEvent> CategoryEvents { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Course>()
            .HasOne(a => a.CourseDetail)
            .WithOne(a => a.Course)
            .HasForeignKey<CourseDetail>(c => c.CourseId);

            modelBuilder.Entity<Event>()
                .HasOne(e => e.EventDetail)
                .WithOne(e => e.Event)
                .HasForeignKey<EventDetail>(ed => ed.EventId);

            modelBuilder.Entity<Blog>()
                .HasOne(b => b.BlogDetail)
                .WithOne(b => b.Blog)
                .HasForeignKey<BlogDetail>(BlogDetail => BlogDetail.BlogId);

            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.TeacherDetail)
                .WithOne(t => t.Teacher)
                .HasForeignKey<TeacherDetail>(TeacherDetail => TeacherDetail.TeacherId);

            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.Skill)
                .WithOne(t => t.Teacher)
                .HasForeignKey<Skill>(s => s.TeacherId);

            
        }
    }
}
