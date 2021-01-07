using EduHomeASPNET.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public string Description { get; set; }
        public DateTime PostedTime { get; set; }
        public int CommentsCount { get; set; }
        public bool HasDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public int BlogDetailId { get; set; }
        public BlogDetail BlogDetail { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public virtual ICollection<CategoryBlog> CategoryBlogs { get; set; }

    }
}
