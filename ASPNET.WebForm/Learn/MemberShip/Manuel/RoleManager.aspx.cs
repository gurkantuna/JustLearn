using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET.WebForm.Learn.MemberShip.Manuel {
    public partial class RoleManager : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnAddRole_Click(object sender, EventArgs e) {
            Roles.CreateRole(textRoleName.Text);
            textRoleName.Text = string.Empty;

            var users = Membership.GetAllUsers();
            //string[] userNames = new string[users.Count];

            List<string> userNames = new List<string>();

            foreach (MembershipUser user in users) {
                userNames.Add(user.UserName);
            }
            Roles.AddUsersToRole(userNames.ToArray(), "Admin");
        }
    }
}