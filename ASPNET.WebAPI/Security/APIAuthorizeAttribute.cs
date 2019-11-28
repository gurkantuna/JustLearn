using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace ASPNET.WebAPI.Security {
    public class APIAuthorizeAttribute : AuthorizeAttribute {

        public override void OnAuthorization(HttpActionContext actionContext) {
            var actionRoles = Roles;
            var userName = HttpContext.Current.User.Identity.Name;

            //var user=GetUserByName()
            //if (user == null && !actionRoles.Contains(user.Role)) {
            //    actionContext.Response = new HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
            //}            
        }
    }
}