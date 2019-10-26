using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static JustLearn.HelperSettings.HelperString;

namespace ASPNET.WebForm.Learn.StateManagement {
    public partial class Cookie : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnSetCookie_Click(object sender, EventArgs e) {
            HttpCookie cookie = new HttpCookie(Cookies.Name, Cookies.NameValue);
            cookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(cookie);
            labelCookie.Text = string.Empty;
        }

        protected void btnGetCookie_Click(object sender, EventArgs e) {
            var nameCookie = Request.Cookies.Get(Cookies.Name);
            if (nameCookie != null) {
                labelCookie.Text = nameCookie.Value;
            }
        }
    }
}