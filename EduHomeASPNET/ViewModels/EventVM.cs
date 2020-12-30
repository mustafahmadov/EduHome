using EduHomeASPNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.ViewModels
{
    public class EventVM
    {
        public Event Event { get; set; }
        public EventDetail EventDetail { get; set; }
        public List<Speaker> Speakers { get; set; }
        public List<SpeakerEvent> SpeakerEvents { get; set; }
    }
}
