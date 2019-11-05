using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET.WebForm.Learn.StateManagement {
    public partial class QueryString1 : System.Web.UI.Page {

        NorthwindContext DbContext = new NorthwindContext();

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                LoadData();
            }
        }

        private void LoadData() {
            GridView1.DataSource = DbContext.Products.ToList();
            GridView1.DataBind();
        }
    }
}