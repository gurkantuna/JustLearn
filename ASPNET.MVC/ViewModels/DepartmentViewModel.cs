using ASPNET.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNET.MVC.ViewModels {
    public class DepartmentViewModel {
        public List<Personel> Personels { get; set; }

        public Department Department { get; set; }
    }
}