using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Entities.Identity
{
    public class AppRole : IdentityRole<string>
    {
        public AppRole() { }
        public AppRole(string roleName)
        {
            Name = roleName;
        }


    }
}
