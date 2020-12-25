using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Profession { get; set; }
        public string Facebook { get; set; }
        public string Pinterest { get; set; }
        public string Vimeo { get; set; }
        public string Twitter { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Skype { get; set; }
        [Required]
        public string Image { get; set; }
        public int TeacherDetailId { get; set; }
        public TeacherDetail TeacherDetail { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
    }
}
