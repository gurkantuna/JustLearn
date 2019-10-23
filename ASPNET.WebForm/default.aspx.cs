using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET.WebForm
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {
            Response.Redirect("DataControls/GridView.aspx");
            //Response.Redirect("DataControls/DataList.aspx");
            //Response.Redirect("DataControls/Repeater.aspx");
        }
    }
}