using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public int Language { get; set; }
        public int TeamLeader { get; set; }
        public string Development { get; set; }
        public string Design { get; set; }
        public string Innovation { get; set; }
        public string Communication { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
