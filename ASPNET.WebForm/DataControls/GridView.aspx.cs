using JustLearn.CustomExtensions;
using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
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
            object sortExp = ViewState["SortExp"];

            if (sortExp != null) {
                switch (SortState) {
                    case SortType.Ascending:
                        GridView1.Sort(sortExp.ToString(), SortDirection.Ascending);
                        break;
                    case SortType.Descending:
                        GridView1.Sort(sortExp.ToString(), SortDirection.Descending);
                        break;
                }
                return;
            }

            GridView1.DataSource = DbProducts.ToList();
            GridView1.DataBind();
        }

        private DbSet<Product> DbProducts {
            get { return SiteBase.DbContext.Products; }
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

        private void /*bool*/ UpdateOrDelete(OperationType operationType, CancelEventArgs e) {

            int productId;
            Product product = null;
            //bool isSuccess = false;

            switch (operationType) {
                case OperationType.Update:
                    var evn = e as GridViewUpdateEventArgs;
                    productId = (int)evn.Keys["ProductId"];
                    product = DbProducts.FirstOrDefault(x => x.ProductID == productId);
                    if (product != null) {
                        product.ProductName = evn.NewValues["ProductName"].ToString();
                        product.UnitPrice = Convert.ToDecimal(evn.NewValues["UnitPrice"]);
                    }
                    break;
                case OperationType.Delete:
                    productId = (int)(e as GridViewDeleteEventArgs).Keys["ProductId"];
                    product = DbProducts.FirstOrDefault(x => x.ProductID == productId);
                    if (product != null) {
                        DbProducts.Remove(product);
                    }
                    break;
            }

            if (product != null) {
                SaveChanges();
            }
        }

        private void SaveChanges() {
            try {
                SiteBase.DbContext.SaveChanges();
            }
            catch (Exception ex) {
                CustomExtensions.ShowJSMessageMox(this, "An error occured while delete", ex);
            }
            FinishIndex();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e) {
            FinishIndex();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e) {

            if (e.CommandName != "Sort") {

                int productId = Convert.ToInt32(e.CommandArgument);
                var product = DbProducts.FirstOrDefault(p => p.ProductID == productId);

                if (product != null) {
                    switch (e.CommandName) {
                        case "Raise":
                            product.UnitPrice *= 1.1m;
                            break;
                    }
                    SaveChanges();
                }
            }
        }

        private void FinishIndex() {
            GridView1.EditIndex = -1;
            LoadData();
        }

        private enum OperationType {
            Update,
            Delete
        }

        private enum SortType {
            Ascending,
            Descending
        }

        private SortType SortState {
            get {
                ViewState["Sort"] = ViewState["Sort"] ?? SortType.Ascending;
                return (SortType)ViewState["Sort"];
            }
            set {
                ViewState["Sort"] = value;
            }
        }

        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e) {

            ViewState["SortExp"] = e.SortExpression;

            switch (SortState) {
                case SortType.Ascending:
                    GridView1.DataSource = DbProducts.SortBy(e.SortExpression, SortDirection.Ascending).ToList();
                    SortState = SortType.Descending;
                    break;
                case SortType.Descending:
                    GridView1.DataSource = DbProducts.SortBy(e.SortExpression, SortDirection.Descending).ToList();
                    SortState = SortType.Ascending;
                    break;
            }
            GridView1.DataBind();
        }
    }
}