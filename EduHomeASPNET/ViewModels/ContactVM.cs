using EduHomeASPNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.ViewModels
{
    public class ContactVM
    {
        public List<ContactDetail> ContactDetails { get; set; }
        public Map Map { get; set; }
    }
}
