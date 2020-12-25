using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.Models
{
    public class Choose
    {
        public int Id { get; set; }
        [MaxLength(length:100)]
        public string Title { get; set; }
        [MaxLength(length: 400)]
        public string FirstContent { get; set; }
        [MaxLength(length: 400)]
        public string SecondContent { get; set; }
    }
}
