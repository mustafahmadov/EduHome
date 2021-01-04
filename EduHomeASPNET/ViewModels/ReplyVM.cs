using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.ViewModels
{
    public class ReplyVM
    {
        [Required]
        public string Name { get; set; }
        
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required,StringLength(maximumLength:50)]
        public string Subject { get; set; }

        [Required, StringLength(maximumLength: 200)]
        public string Message { get; set; }

    }
}
