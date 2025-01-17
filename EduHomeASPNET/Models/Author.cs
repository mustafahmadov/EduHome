﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        public bool HasDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
