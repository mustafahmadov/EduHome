﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeASPNET.ViewModels
{
    public class CreateRoleVM
    {
        [Required]
        public string RoleName { get; set; }
    }
}
