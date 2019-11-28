using ASPNET.WebAPI.Attributes;
using ASPNET.WebAPI.Security;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ASPNET.WebAPI {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {
            // Web API configuration and services
            config.EnableCors();

            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Filters.Add(new ApiExceptionAttribute());
            config.MessageHandlers.Add(new APIKeyHandler());

            //config.Routes.MapHttpRoute(
            //    name: "SampleRoute",
            //    routeTemplate: "Sample/List/{sort}/{page}",
            //    defaults: new { controller = "Sample", action = "Index" }
            //    );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",//DomainAddress
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();//"productID": 3

        }
    }
}
