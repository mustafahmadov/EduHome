using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class AuthorBlog
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
