using ASPNET.MVC.Models;
using ASPNET.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNET.MVC.Controllers {
    public class DepartmentController : Controller {
        // GET: Department
        public ActionResult Index() {
            return View();
        }

        public ActionResult Detail(int id) {
            ViewData["id"] = id;
            Department d = new Department { Id = 1, Name = "Department1" };

            Department d2 = new Department { Id = 2, Name = "Department2" };
            ViewData["dep"] = d2;//Not recommended

            Department d3 = new Department { Id = 3, Name = "Department3" };
            ViewBag.Department = d3;//Not recommended

            return View();
        }

        public ActionResult Detail2() {

            Personel p = new Personel { Id = 1, Name = "JohnDoe" };
            Personel p2 = new Personel { Id = 2, Name = "JohnDoe2" };
            Personel p3 = new Personel { Id = 3, Name = "JohnDoe3" };

            Department d = new Department { Id = 4, Name = "Department" };
            d.Personels.Add(p);
            d.Personels.Add(p2);
            d.Personels.Add(p3);

            //p.DepartmentId = 2;
            //p2.DepartmentId = 2;
            //p3.DepartmentId = 2;

            DepartmentViewModel model = new DepartmentViewModel();

            model.Department = d;
            model.Personels = d.Personels;

            return View(model);
        }
    }
}