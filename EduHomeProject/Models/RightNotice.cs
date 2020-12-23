using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class RightNotice
    {
        public int Id { get; set; }
        [MaxLength(length: 40)]
        public string Title { get; set; }
        [MaxLength(length:250)]
        public string Content { get; set; }
    }
}
