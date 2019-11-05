using JustLearn.HelperSettings;
using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET.WebForm.Learn.Caching {
    public partial class GetProducts : System.Web.UI.Page {

        NorthwindContext DbContext = new NorthwindContext();

        protected void Page_Load(object sender, EventArgs e) {
            if (Request.QueryString[HelperString.CategoryId] != null) {

                var categoryId = int.Parse(Request.QueryString[HelperString.CategoryId]);
                rpProducts.DataSource = DbContext.Products.Where(p => p.CategoryID == categoryId).ToList();
                rpProducts.DataBind();
            }
        }
    }
}