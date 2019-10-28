using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace ASPNET.WebForm.Learn.MemberShip.Manuel {
    public partial class Login : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (Request.QueryString["msg"] != null) {
                labelMessage.Visible = true;
                labelMessage.Text = "User created succesfully. Please login!";
            }

            if (Page.User.Identity.IsAuthenticated) {
                labelUserName.Text = Page.User.Identity.Name;
            }
            else {
                labelUserName.Text = "Invalid username or paswsword";
            }
        }

        protected void btnLogIn_Click(object sender, EventArgs e) {
            var userName = textUserName.Text;
            var password = textPassword.Text;

            var isExist = Membership.ValidateUser(userName, password);
            if (isExist) {
                FormsAuthentication.RedirectFromLoginPage(userName, true);
            }
        }
    }
}