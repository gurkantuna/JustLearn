using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET.WebForm.Learn.Caching {
    public partial class OutputCaching : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            labelDateTime.Text = DateTime.Now.ToString();
        }
    }
}