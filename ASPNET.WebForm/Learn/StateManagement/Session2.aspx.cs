using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static JustLearn.HelperSettings.HelperString;

namespace ASPNET.WebForm.Learn.StateManagement {
    public partial class Session2 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (Session[Sessions.Name] != null) {
                labelSessionValue.Text = Session[Sessions.Name].ToString();
            }
        }
    }
}