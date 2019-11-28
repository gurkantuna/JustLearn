using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace ASPNET.WebAPI {
    public class WebApiApplication : System.Web.HttpApplication {
        protected void Application_Start() {            
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        protected void Application_Error(object sender, EventArgs e) {
            var ex = Server.GetLastError();

            //log the error
            //_Logger.Error(ex);
        }
    }
}
