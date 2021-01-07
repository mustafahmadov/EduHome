using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public bool HasDeleted { get; set; }
        public DateTime DeletedTime { get; set; }
        public virtual ICollection<CategoryCourse> CategoryCourses { get; set; }
        public virtual ICollection<CategoryBlog> CategoryBlogs { get; set; }
        public virtual ICollection<CategoryEvent> CategoryEvents { get; set; }
    }
}
