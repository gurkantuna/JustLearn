﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static JustLearn.HelperSettings.HelperString;

namespace ASPNET.WebForm.Learn.StateManagement {
    public partial class Session : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnSetSession_Click(object sender, EventArgs e) {
            Session.Add(Sessions.Name, textName.Text);
        }
    }
}