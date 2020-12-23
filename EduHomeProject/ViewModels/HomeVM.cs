using EduHomeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<LeftNotice> LeftNotices { get; set; }
        public List<RightNotice> RightNotices { get; set; }

        public Choose Choose { get; set; }
    }
}
