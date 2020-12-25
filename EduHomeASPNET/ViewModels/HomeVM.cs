using EduHomeASPNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Notice> LeftNotices { get; set; }
        public List<RightNotice> RightNotices { get; set; }

        public Choose Choose { get; set; }
        public List<Course> Courses { get; set; }
        public List<CourseDetail> CourseDetails { get; set; }
        public List<Event> Events { get; set; }
        public List<EventDetail> EventDetails { get; set; }
        public About About { get; set; }
        public Video Video { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<BlogDetail> BlogDetails { get; set; }
        public List<Author> Authors { get; set; }
    }
}
