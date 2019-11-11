using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace ASPNET.MVC.Helpers {
    public static class CustomExtensions {

        public static bool IsInAllRoles(this IPrincipal principal, params string[] roles) {
            return roles.All(r => principal.IsInRole(r));
        }

        public static bool IsInAnyRoles(this IPrincipal principal, params string[] roles) {
            return roles.Any(r => principal.IsInRole(r));
        }
    }
}