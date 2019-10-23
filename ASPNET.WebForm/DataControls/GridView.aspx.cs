using JustLearn.CustomExtensions;
using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET.WebForm.DataControls {
    public partial class GridView : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {

            if (!IsPostBack) {
                LoadData();
            }
        }

        private void LoadData() {
            GridView1.DataSource = SiteBase.DbContext.Products.ToList();
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e) {
            GridView1.EditIndex = e.NewEditIndex;
            LoadData();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e) {
            UpdateOrDelete(OperationType.Update, e);
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e) {
            UpdateOrDelete(OperationType.Delete, e);
        }

        private bool UpdateOrDelete(OperationType operationType, CancelEventArgs e) {

            int productId;
            Product product = null;
            bool isSuccess = false;

            switch (operationType) {
                case OperationType.Update:
                    var evn = e as GridViewUpdateEventArgs;
                    productId = (int)evn.Keys["ProductId"];
                    product = SiteBase.DbContext.Products.FirstOrDefault(x => x.ProductID == productId);
                    if (product != null) {
                        product.ProductName = evn.NewValues["ProductName"].ToString();
                        product.UnitPrice = Convert.ToDecimal(evn.NewValues["UnitPrice"]);
                    }
                    break;
                case OperationType.Delete:
                    productId = (int)(e as GridViewDeleteEventArgs).Keys["ProductId"];
                    product = SiteBase.DbContext.Products.FirstOrDefault(x => x.ProductID == productId);
                    if (product != null) {
                        SiteBase.DbContext.Products.Remove(product);
                    }
                    break;
            }

            if (product != null) {
                try {
                    isSuccess = SiteBase.DbContext.SaveChanges() > 0;
                }
                catch (Exception ex) {
                    CustomExtensions.ShowJSMessageMox(this, "An error occured while delete", ex);
                }
                FinishIndex();
            }
            return isSuccess;
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e) {
            FinishIndex();
        }

        private void FinishIndex() {
            GridView1.EditIndex = -1;
            LoadData();
        }

        private enum OperationType {
            Update,
            Delete
        }
    }
}