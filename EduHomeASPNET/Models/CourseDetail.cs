using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.Models
{
    public class CourseDetail
    {
        public int Id { get; set; }

        public string Duration { get; set; }
        public string Price { get; set; }
        [Required]
        public string Language { get; set; }
        public string StudentsPerGroup { get; set; }
        public string StudentsCount { get; set; }
        public string ClassDuration { get; set; }
        [Required]
        public string SkillLevel { get; set; }
        public string Content { get; set; }
        public string About { get; set; }
        public string AboutApply { get; set; }
        public string AboutCertification { get; set; }
        public bool HasDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }
    }
}
