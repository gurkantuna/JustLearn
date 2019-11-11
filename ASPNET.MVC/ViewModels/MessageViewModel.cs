using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNET.MVC.ViewModels {
    public class MessageViewModel {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public string Url { get; set; }
        public string LinkText { get; set; }
    }
}