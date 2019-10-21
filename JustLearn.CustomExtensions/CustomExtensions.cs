using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace JustLearn.CustomExtensions
{
    public static class CustomExtensions
    {
        public static void ShowJSMessageMox(this TemplateControl page, string message, Exception ex = null) {
            if (page is Page p) {
                if (!p.ClientScript.IsClientScriptBlockRegistered("PopupScript")) {

                    var exMessage = string.Empty;

                    if (ex != null) {
                        if (ex.InnerException != null && ex.InnerException.InnerException != null) {
                            exMessage = ex.InnerException.InnerException.Message;
                        }
                        else if (ex.Message != null) {
                            exMessage = ex.Message;
                        }
                    }

                    if (exMessage.Contains("\"")) exMessage = exMessage.Replace("\"", "");
                    if (exMessage.Contains("\'")) exMessage = exMessage.Replace("\'", "");
                    if (exMessage.Contains("\r")) exMessage = exMessage.Replace("\r", "");
                    if (exMessage.Contains("\t")) exMessage = exMessage.Replace("\t", "");
                    if (exMessage.Contains("\n")) exMessage = exMessage.Replace("\n", " ");                    

                    if (ex != null) {
                        p.ClientScript.RegisterClientScriptBlock(page.GetType(), "AlertBox", $"alert('{message}: {exMessage}')", true);
                    }
                    else {
                        p.ClientScript.RegisterClientScriptBlock(page.GetType(), "AlertBox", $"alert('{message}')", true);
                    }
                }
            }
        }
    }
}
