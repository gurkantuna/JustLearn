using JustLearn.CustomExtensions;
using System;
using System.Web.Security;

namespace ASPNET.WebForm.Learn.MemberShip.Manuel {
    public partial class Register : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnRegister_Click(object sender, EventArgs e) {
            var userName = textUserName.Text;
            var passwprd = textPassword.Text;
            var email = textEmail.Text;
            var question = textQuestion.Text;
            var answer = textAnswer.Text;
            MembershipCreateStatus status;

            Membership.CreateUser(userName, passwprd, email, question, answer, true, out status);

            if (status == MembershipCreateStatus.Success) {
                this.ShowJSMessageBox("User created succesfully");
                Response.Redirect("Login.aspx?msg=1");
            }
            else {
                this.ShowJSMessageBox("User not created!");
            }
        }
    }
}