﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        public string Image {get;set;}
        
        [NotMapped]
        public IFormFile Photo { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime OrganizedDay { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        [Required]
        public string PlacedArea { get; set; }
        public bool HasDeleted { get; set; }
        public DateTime DeletedTime { get; set; }
        public bool ExperiedDate { get; set; }
        public int EventDetailId { get; set; }
        public EventDetail EventDetail { get; set; }

        public virtual ICollection<SpeakerEvent> SpeakerEvents { get; set; }

        public virtual ICollection<CategoryEvent> CategoryEvents { get; set; }



    }
}
