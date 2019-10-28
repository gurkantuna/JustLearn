using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Basic.jQuery {
    public partial class Clock : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            Response.Write(DateTime.Now.ToString());
        }
    }
}