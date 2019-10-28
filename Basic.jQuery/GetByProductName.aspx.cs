using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Basic.jQuery {
    public partial class GetByProductName : System.Web.UI.Page {

        private NorthwindContext _context;

        public NorthwindContext DbContext {
            get {
                _context = _context ?? new NorthwindContext();
                return _context;
            }
            set { _context = value; }
        }


        protected void Page_Load(object sender, EventArgs e) {

            var productName = Request.Form["productName"];
            var products = DbContext.Products.Where(p => p.ProductName.Contains(productName)).Select(p => new { p.ProductName });
            StringBuilder content = new StringBuilder();

            content.Append("<tr>");
            content.Append($"<th scope=\"col\">Product Name</th>");
            content.Append("<th>");
            content.Append("</tr>");

            foreach (var p in products) {
                content.Append("<tr>");
                content.Append("<td>");
                content.Append(p.ProductName);
                content.Append("</td>");
                content.Append("</tr>");
            }

            Response.Write(content.ToString());
            Response.End();
        }
    }
}