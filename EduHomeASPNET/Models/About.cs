﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.Models
{
    public class About
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        public string Title { get; set; }
        public string FirstContent { get; set; }
        public string SecondContent { get; set; }
    }
}