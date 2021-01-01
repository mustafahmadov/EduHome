﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.Models
{
    public class TeacherDetail
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Degree { get; set; }
        public string Hobbies { get; set; }
        public string Experience { get; set; }
        public string Faculty { get; set; }
        public bool HasDeleted { get; set; }
        public DateTime DeletedTime { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
