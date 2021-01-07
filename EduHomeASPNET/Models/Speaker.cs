using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        [Required]
        public string Fullname { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }

        public virtual ICollection<SpeakerEvent> SpeakerEvents { get; set; }
    }
}
