using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static JustLearn.HelperSettings.HelperString;

namespace ASPNET.WebForm.Learn.StateManagement {
    public partial class QueryString2 : System.Web.UI.Page {

        NorthwindContext DbContext = new NorthwindContext();

        protected void Page_Load(object sender, EventArgs e) {

            if (Request.QueryString[ProductId] != null) {
                var productId = int.Parse(Request.QueryString[ProductId]);
                var product = DbContext.Products.FirstOrDefault(p => p.ProductID == productId);

                labelProductId.Text = product.ProductID.ToString();
                labelProductName.Text = product.ProductName;
                labelUnitPrice.Text = string.Format("{0:n}", product.UnitPrice);
            }
            else {
                Response.Redirect("/");
            }
        }
    }
}