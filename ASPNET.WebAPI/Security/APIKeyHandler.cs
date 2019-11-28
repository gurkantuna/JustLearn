using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace ASPNET.WebAPI.Security {
    public class APIKeyHandler : DelegatingHandler {

        NorthwindContext db = new NorthwindContext();

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) {

            //request.Headers.GetValues("apiKey").FirstOrDefault();//You have to send apiKey with in Request Guid Header(apiKey:1234-5678-9012-3456) or in QueryString as below

            var queryString = request.RequestUri.ParseQueryString();
            var apiKey = queryString["apiKey"];


            var user = db.aspnet_Users.FirstOrDefault(x => x.UserId.ToString() == apiKey);
            if (user != null) {
                var principal = new ClaimsPrincipal(new GenericIdentity(user.UserName, "APIKey"));
                HttpContext.Current.User = principal;
            }

            return base.SendAsync(request, cancellationToken);
        }
    }
}