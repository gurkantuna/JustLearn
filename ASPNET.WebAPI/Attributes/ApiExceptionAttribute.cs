using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;

namespace ASPNET.WebAPI.Attributes {
    public class ApiExceptionAttribute : ExceptionFilterAttribute {

        public override void OnException(HttpActionExecutedContext actionExecutedContext) {
            HttpResponseMessage responseMessage = new HttpResponseMessage(System.Net.HttpStatusCode.BadGateway);
            responseMessage.ReasonPhrase = actionExecutedContext.Exception.Message;
            throw new HttpResponseException(responseMessage);
            //base.OnException(actionExecutedContext);            
        }
    }
}