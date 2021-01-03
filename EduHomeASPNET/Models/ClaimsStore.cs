using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EduHomeASPNET.Models
{
    public static class ClaimsStore
    {
        public static List<Claim> AllClaims = new List<Claim>()
        {
        new Claim("Update Course","Update Course"),
        new Claim("Detail Course","Detail Course"),
        new Claim("Create Course", "Create Course"),
        };
    }
}
