﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class StudentCourse
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }
    }
}
