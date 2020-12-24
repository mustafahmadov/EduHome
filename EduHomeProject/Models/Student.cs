using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Image { get; set; }
        public string Phone { get; set; }
        public bool HasDeleted { get; set; }
        public DateTime DeletedTime { get; set; }
        public virtual ICollection<StudentComments> studentComments { get; set; }
    }
}
