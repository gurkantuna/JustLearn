using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET.WebForm.Learn.StateManagement {
    public partial class Application : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            labelOnlineVisitors.Text = Application["online"].ToString();
            labelTotalVisitors.Text = Application["total"].ToString();
        }
    }
}