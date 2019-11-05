using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;
using static JustLearn.HelperSettings.HelperString;

namespace ASPNET.WebForm.Learn.Caching {
    public partial class DataCaching : System.Web.UI.Page {

        NorthwindContext DbContext = new NorthwindContext();

        protected void Page_Load(object sender, EventArgs e) {

            if (!IsPostBack) {
                LoadData();
            }
        }

        private void LoadData() {
            /*
            With Table and SQL
             
            SqlCacheDependency dependency = new SqlCacheDependency("NortwindDependency", "Products");//web.config
            Cache.Insert(Caches.Products, SiteBase.DbContext.Products.ToList(), dependency);
            */

            if (Cache[Caches.Products] == null) {
                Cache.Insert(Caches.Products, DbContext.Products.ToList(), null, DateTime.MaxValue, TimeSpan.FromSeconds(10));
            }

            gvProducts.DataSource = DbContext.Products.ToList();
            gvProducts.DataBind();
        }
    }
}