using JustLearn.CustomExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET.WebForm.DataControls
{
    public partial class DataList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {
            if (!Page.IsPostBack) {
                ReloadDataList();
            }
        }

        private void ReloadDataList() {
            DataList1.DataSource = SiteBase.DbContext.Products.ToList();
            DataList1.DataBind();
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e) {
            
        }

        protected void DataList1_EditCommand(object source, DataListCommandEventArgs e) {
            if (e.CommandName == "Edit") {
                DataList1.EditItemIndex = e.Item.ItemIndex;
                ReloadDataList();
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e) {
            DataList1.EditItemIndex = 2;
            ReloadDataList();
        }

        protected void DataList1_UpdateCommand(object source, DataListCommandEventArgs e) {

            if (e.CommandName == "Update") {
                try {
                    TextBox textProductName = e.Item.FindControl("textProductName") as TextBox;
                    TextBox textUnitPrice = e.Item.FindControl("textUnitPrice") as TextBox;
                    var productName = textProductName.Text;
                    var unitPrice = decimal.Parse(textUnitPrice.Text);
                    var productId = Convert.ToInt32(e.CommandArgument);
                    var product = SiteBase.DbContext.Products.FirstOrDefault(p => p.ProductID == productId);
                    product.ProductName = productName;
                    product.UnitPrice = unitPrice;
                    SiteBase.DbContext.SaveChanges();
                    DataList1.EditItemIndex = -1;//Finished update operation and leave EditItemTemplate
                    ReloadDataList();
                }
                catch (Exception ex) {
                    this.ShowJSMessageMox("An error occured while update", ex);
                }
            }
        }

        protected void DataList1_DeleteCommand(object source, DataListCommandEventArgs e) {

            if (e.CommandName == "Delete") {
                try {
                    int productId = Convert.ToInt32(e.CommandArgument);
                    var product = SiteBase.DbContext.Products.FirstOrDefault(p => p.ProductID == productId);

                    SiteBase.DbContext.Products.Remove(product);
                    SiteBase.DbContext.SaveChanges();
                    ReloadDataList();
                    DataList1.EditItemIndex = -1;//Finished delete operation and leave EditItemTemplate
                    this.ShowJSMessageMox($"{product.ProductName} deleted succesfully");
                }
                catch (Exception ex) {                    
                    this.ShowJSMessageMox("An error occured while delete", ex);
                }
            }
        }

        protected void DataList1_CancelCommand(object source, DataListCommandEventArgs e) {
            DataList1.EditItemIndex = -1;
            ReloadDataList();
        }
    }
}