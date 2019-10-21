using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET.WebForm
{
    public partial class SiteBase : System.Web.UI.MasterPage
    {
        private static NorthwindContext _context;

        public static NorthwindContext DbContext {
            get {
                _context = _context ?? new NorthwindContext();
                return _context;
            }
            set { _context = value; }
        }

        protected void Page_Load(object sender, EventArgs e) {

        }
    }
}