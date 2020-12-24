using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class EventDetail
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [MaxLength(length:300)]
        public string FirstContent { get; set; }
        [MaxLength(length: 300)]
        public string SecondContent { get; set; }
        [MaxLength(length: 300)]
        public string ThirdContent { get; set; }
        [Required]
        public string DetailedImage { get; set; }
        [Required]
        public string DetailedPlacedArea { get; set; }

    }
}
