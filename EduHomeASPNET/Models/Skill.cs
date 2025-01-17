﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public int? Language { get; set; }
        public int? TeamLeader { get; set; }
        public int? Development { get; set; }
        public int? Design { get; set; }
        public int? Communication { get; set; }
        public int? Innovation { get; set; }
        public bool HasDeleted { get; set; }
        public DateTime DeletedTime { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
