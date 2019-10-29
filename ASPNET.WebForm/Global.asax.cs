using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ASPNET.WebForm {
    public class Global : System.Web.HttpApplication {

        protected void Application_Start(object sender, EventArgs e) {
            Application["online"] = 0;
            Application["total"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e) {
            var online = (int)Application["online"];
            online++;
            Application["online"] = online;

            var total = (int)Application["total"];
            total++;
            Application["total"] = total;
        }

        protected void Application_BeginRequest(object sender, EventArgs e) {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e) {

        }

        protected void Application_Error(object sender, EventArgs e) {

        }

        protected void Session_End(object sender, EventArgs e) {
            var online = (int)Application["online"];
            online--;
            Application["online"] = online;
        }

        protected void Application_End(object sender, EventArgs e) {

        }
    }
}