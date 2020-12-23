using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string Price { get; set; }
        public string Language { get; set; }
        public string StudentsPerGroup { get; set; }
        public string StudentsCount { get; set; }
        public string ClassDuration { get; set; }
        public string SkillLevel { get; set; }
        public string StartDate { get; set; }
        public bool HasDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }
    }
}
