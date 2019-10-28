using Pattern.Domain.Models;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace Basic.jQuery {
    public partial class Default : System.Web.UI.Page {

        private NorthwindContext _context;

        public NorthwindContext DbContext {
            get {
                _context = _context ?? new NorthwindContext();
                return _context;
            }
            set { _context = value; }
        }

        protected void Page_Load(object sender, EventArgs e) {

            if (!IsPostBack) {
                LoadData();
            }
        }

        private void LoadData() {
            tableProducts.DataSource = DbContext.Products.Select(x => new { x.ProductName }).ToList();
            tableProducts.DataBind();
        }

        protected void btnSyncClock_Click(object sender, EventArgs e) {
            labelClock.Text = DateTime.Now.ToString();
        }
    }
}