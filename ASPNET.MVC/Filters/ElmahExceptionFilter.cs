using Elmah;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNET.MVC.Filters {
    //You need this filter for Elmah if you choose <customErrors mode="On" /> in Web.config
    public class ElmahExceptionFilter : IExceptionFilter {
        public void OnException(ExceptionContext filterContext) {
            if (filterContext.ExceptionHandled) {
                ErrorSignal.FromCurrentContext().Raise(filterContext.Exception);
            }
        }
    }
}