using JustLearn.CustomExtensions;
using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET.WebForm.DataControls {
    public partial class DataList : System.Web.UI.Page {

        NorthwindContext DbContext = new NorthwindContext();

        protected void Page_Load(object sender, EventArgs e) {
            if (!Page.IsPostBack) {
                LoadDataList();
            }
        }

        private void LoadDataList() {
            DataList1.DataSource = DbContext.Products.ToList();
            DataList1.DataBind();
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e) {

            if (!string.IsNullOrEmpty(e.CommandName)) {
                switch (e.CommandName) {

                    case "Insert":
                        var textName = e.Item.FindControl("textProductName") as TextBox;
                        var textUnitPrice = e.Item.FindControl("textUnitPrice") as TextBox;
                        var textUnitsInStock = e.Item.FindControl("textUnitsInStock") as TextBox;

                        var p = new Product();
                        p.ProductName = textName.Text;
                        p.UnitPrice = decimal.Parse(textUnitPrice.Text);
                        p.UnitsInStock = short.Parse(textUnitsInStock.Text);

                        DbContext.Products.Add(p);
                        break;
                }
                DbContext.SaveChanges();
                LeaveEdit();
            }
        }

        protected void DataList1_EditCommand(object source, DataListCommandEventArgs e) {
            if (e.CommandName == "Edit") {
                DataList1.EditItemIndex = e.Item.ItemIndex;
                LoadDataList();
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e) {
            DataList1.EditItemIndex = 2;
            LoadDataList();
        }

        protected void DataList1_UpdateCommand(object source, DataListCommandEventArgs e) {

            if (e.CommandName == "Update") {
                try {
                    TextBox textProductName = e.Item.FindControl("textProductName") as TextBox;
                    TextBox textUnitPrice = e.Item.FindControl("textUnitPrice") as TextBox;
                    var productName = textProductName.Text;
                    var unitPrice = decimal.Parse(textUnitPrice.Text);
                    var productId = Convert.ToInt32(e.CommandArgument);
                    var product = DbContext.Products.FirstOrDefault(p => p.ProductID == productId);
                    product.ProductName = productName;
                    product.UnitPrice = unitPrice;
                    DbContext.SaveChanges();
                    DataList1.EditItemIndex = -1;//Finished update operation and leave EditItemTemplate
                    LoadDataList();
                }
                catch (Exception ex) {
                    this.ShowJSMessageBox("An error occured while update", ex);
                }
            }
        }

        protected void DataList1_DeleteCommand(object source, DataListCommandEventArgs e) {

            if (e.CommandName == "Delete") {
                try {
                    int productId = Convert.ToInt32(e.CommandArgument);
                    var product = DbContext.Products.FirstOrDefault(p => p.ProductID == productId);

                    DbContext.Products.Remove(product);
                    DbContext.SaveChanges();
                    LoadDataList();
                    DataList1.EditItemIndex = -1;//Finished delete operation and leave EditItemTemplate
                    this.ShowJSMessageBox($"{product.ProductName} deleted succesfully");
                }
                catch (Exception ex) {
                    this.ShowJSMessageBox("An error occured while delete", ex);
                }
            }
        }

        protected void DataList1_CancelCommand(object source, DataListCommandEventArgs e) {
            LeaveEdit();
        }

        private void LeaveEdit() {
            DataList1.EditItemIndex = -1;
            LoadDataList();
        }

        protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e) {

            if (e.Item.ItemType == ListItemType.Header) {
                var ddlCategories = e.Item.FindControl("ddlCategories") as DropDownList;
                ddlCategories.DataSource = DbContext.Categories.ToList();
                ddlCategories.DataValueField = "CategoryId";
                ddlCategories.DataTextField = "CategoryName";
                ddlCategories.DataBind();
            }
        }
    }
}