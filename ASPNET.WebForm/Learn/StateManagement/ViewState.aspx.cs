using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static JustLearn.HelperSettings.HelperString;

namespace ASPNET.WebForm.Learn.StateManagement {
    public partial class ViewState : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnSetViewState_Click(object sender, EventArgs e) {
            ViewState[ProductId] = 1;
            labelProductId.Text = string.Empty;
        }

        protected void btnGetViewState_Click(object sender, EventArgs e) {
            var viewState = ViewState[ProductId];
            if (viewState != null) {
                int produxtID = (int)viewState;
                labelProductId.Text = produxtID.ToString();
            }
        }
    }
}