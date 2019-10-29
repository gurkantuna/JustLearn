using JustLearn.HelperSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET.WebForm.Learn.Caching {
    public partial class GetProducts : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (Request.QueryString[HelperString.CategoryId] != null) {

                var categoryId = int.Parse(Request.QueryString[HelperString.CategoryId]);
                rpProducts.DataSource = SiteBase.DbContext.Products.Where(p => p.CategoryID == categoryId).ToList();
                rpProducts.DataBind();
            }
        }
    }
}