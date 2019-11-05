using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET.WebForm.Learn.Caching {
    public partial class OutputCaching2 : System.Web.UI.Page {

        NorthwindContext DbContext = new NorthwindContext();

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                LoadData();
            }
        }

        private void LoadData() {
            rpCategories.DataSource = DbContext.Categories.ToList();
            rpCategories.DataBind();
        }
    }
}