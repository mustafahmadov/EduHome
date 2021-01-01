using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.Models
{
    public class EventDetail
    {
        public int Id { get; set; }
        [MaxLength(length:300)]
        public string FirstContent { get; set; }
        [MaxLength(length: 300)]
        public string SecondContent { get; set; }
        [MaxLength(length: 300)]
        public string ThirdContent { get; set; }
        [Required]
        public string DetailedPlacedArea { get; set; }
        public bool HasDeleted { get; set; }
        public DateTime? DeletedTime{ get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }

    }
}
