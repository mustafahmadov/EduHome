using System;

namespace EduHomeProject.Models
{
    public class StudentComment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool HasDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}