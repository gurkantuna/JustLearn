using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pattern.Domain.Models;

namespace ASPNET.MVC.ViewModels {
    public class LoginViewModel {
        public aspnet_Users User { get; set; }
        public bool RememberMe { get; set; }
    }
}