﻿using EduHomeASPNET.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<LeftNotice> LeftNotices { get; set; }
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    Id = 1,
                    Name = "ADVANCE PHP WORKSHOP",
                    Image = "event5.jpg",
                    HasDeleted = false,
                    ExperiedDate = false,
                    PlacedArea = "Baku",
                    EventDetailId = 1
                },
                new Event
                {
                    Id = 2,
                    Name = "ADVANCE PHP WORKSHOP",
                    Image = "event6.jpg",
                    HasDeleted = false,
                    ExperiedDate = false,
                    PlacedArea = "Baku",
                    EventDetailId = 2
                },
                new Event
                {
                    Id = 3,
                    Name = "ADVANCE PHP WORKSHOP",
                    Image = "event7.jpg",
                    HasDeleted = false,
                    ExperiedDate = false,
                    PlacedArea = "Baku",
                    EventDetailId = 3
                },
                new Event
                {
                    Id = 4,
                    Name = "ADVANCE PHP WORKSHOP",
                    Image = "event8.jpg",
                    HasDeleted = false,
                    ExperiedDate = false,
                    PlacedArea = "Baku",
                    EventDetailId = 4
                },
                new Event
                {
                    Id = 5,
                    Name = "ADVANCE PHP WORKSHOP",
                    Image = "event9.jpg",
                    HasDeleted = false,
                    ExperiedDate = false,
                    PlacedArea = "Baku",
                    EventDetailId = 5
                },
                new Event
                {
                    Id = 6,
                    Name = "ADVANCE PHP WORKSHOP",
                    Image = "event10.jpg",
                    HasDeleted = false,
                    ExperiedDate = false,
                    PlacedArea = "Baku",
                    EventDetailId = 1
                },
                new Event
                {
                    Id = 7,
                    Name = "ADVANCE PHP WORKSHOP",
                    Image = "event11.jpg",
                    HasDeleted = false,
                    ExperiedDate = false,
                    PlacedArea = "Baku",
                    EventDetailId = 7
                },
                new Event
                {
                    Id = 8,
                    Name = "ADVANCE PHP WORKSHOP",
                    Image = "event12.jpg",
                    HasDeleted = false,
                    ExperiedDate = false,
                    PlacedArea = "Baku",
                    EventDetailId = 8
                },
                new Event
                {
                    Id = 9,
                    Name = "ADVANCE PHP WORKSHOP",
                    Image = "event13.jpg",
                    HasDeleted = false,
                    ExperiedDate = false,
                    PlacedArea = "Baku",
                    EventDetailId = 9
                }
                );
        }


    }
}