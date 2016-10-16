using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurantSystem.Security
{
    internal static class SecurityRoles
    {
        public const string WebsiteAdmin = "WebsiteAdmin";
        public const string RegisteredUsers = "RegisteredUsers";
        public const string Staff = "Staff";
        public const string Auditor = "Auditor";

        public static List<string> StartupSecurityRole
        {
            get
            {
                List<string> rolelist = new List<string>();
                rolelist.Add(WebsiteAdmin);
                rolelist.Add(RegisteredUsers);
                rolelist.Add(Staff);
                rolelist.Add(Auditor);
                return rolelist;
            }
        }



    }
}
