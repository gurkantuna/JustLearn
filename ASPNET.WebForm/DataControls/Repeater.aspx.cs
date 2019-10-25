using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ASPNET.WebForm.DataControls {
    public partial class Repeater : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            if (!IsPostBack) {
                LoadProducts();
            }
        }

        private void LoadProducts() {
            repeater1.DataSource = SiteBase.DbContext.Products.ToList();
            repeater1.DataBind();
        }

        protected void LinkButtonDesc_Click(object sender, EventArgs e) {
            repeater1.DataSource = SiteBase.DbContext.Products.ToList().OrderByDescending(x => x.UnitPrice);
            repeater1.DataBind();
        }

        protected void LinkButtonAsc_Click(object sender, EventArgs e) {
            repeater1.DataSource = SiteBase.DbContext.Products.ToList().OrderBy(x => x.UnitPrice);
            repeater1.DataBind();
        }

        protected string EvalPrice() {
            var currentPrice = Convert.ToDecimal(Eval("UnitPrice"));
            var priceAsString = currentPrice == 0 ? "0" : currentPrice.ToString("n");
            return priceAsString;
        }

        protected void repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e) {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem) {
                Product p = (Product)e.Item.DataItem;

                List<HtmlTableCell> cells = new List<HtmlTableCell>();
                HtmlTableCell cellPrice = e.Item.FindControl("cellPrice") as HtmlTableCell;
                cells.Add(cellPrice);
                HtmlTableCell cellPriceStatus = e.Item.FindControl("cellPriceStatus") as HtmlTableCell;
                cells.Add(cellPriceStatus);

                if (!p.UnitPrice.HasValue) {
                    cellPriceStatus.InnerText = "N/A";
                    return;
                }

                foreach (var cell in cells) {
                    if (p.UnitPrice > 50) {

                        cell.Style.Add("color", "red");
                        cellPriceStatus.InnerText = "Expensive";
                    }
                    else if (p.UnitPrice == 50) {
                        return;
                    }
                    else {
                        cell.Style.Add("color", "green");
                        cellPriceStatus.InnerText = "Chip";
                    }
                }
            }
        }

        protected void repeater1_ItemCommand(object source, RepeaterCommandEventArgs e) {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem) {

                var productId = Convert.ToInt32(e.CommandArgument);
                var product = SiteBase.DbContext.Products.FirstOrDefault(p => p.ProductID == productId);

                if (product != null) {

                    switch (e.CommandName) {

                        case "Raise":
                            product.UnitPrice *= 1.1m;
                            break;
                    }
                    SiteBase.DbContext.SaveChanges();
                    LoadProducts();
                }
            }
        }
    }
}