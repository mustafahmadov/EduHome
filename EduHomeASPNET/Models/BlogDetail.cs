using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.Models
{
    public class BlogDetail
    {
        public int Id { get; set; }
        [Required]
        public string DetailedImage { get;set;}
        public string FirstContent { get; set; }
        public string SecondContent { get; set; }
        public string ThirdContent { get; set; }
        public string FourthContent { get; set; }
        public bool HasDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
