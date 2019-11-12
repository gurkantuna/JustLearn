using ASPNET.MVC.App_Start;
using ASPNET.MVC.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ASPNET.MVC {
    public class MvcApplication : System.Web.HttpApplication {
        protected void Application_Start() {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //GlobalFilters.Filters.Add(new ElmahExceptionFilter());//You have to write this line for Elmah if you choose <customErrors mode="On" /> in web.config
            GlobalFilters.Filters.Add(new HandleErrorAttribute());//Catch error
        }

        protected void Application_Error(object sender, EventArgs e) {
            var ex = Server.GetLastError();
            //log the error!
            //_Logger.Error(ex);
        }
    }
}
