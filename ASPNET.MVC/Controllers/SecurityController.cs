using ASPNET.MVC.ViewModels;
using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ASPNET.MVC.Controllers {
    public class SecurityController : Controller {

        //NorthwindContext db = new NorthwindContext();

        // GET: Security
        public ActionResult Login() {
            //return View(new aspnet_Users());
            return View(new LoginViewModel() { User = new aspnet_Users() });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model) {
            var u = model.User;
            var validate = Membership.ValidateUser(u.UserName, u.aspnet_Membership.Password);
            if (validate) {
                if (model.RememberMe) {
                    FormsAuthentication.RedirectFromLoginPage(u.UserName, true);
                }
                else {
                    FormsAuthentication.RedirectFromLoginPage(u.UserName, false);
                }
                return RedirectToAction("Index", "Home");
            }
            else {
                return View(u);
            }
        }
    }
}