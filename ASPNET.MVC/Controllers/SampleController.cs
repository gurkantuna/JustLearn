using ASPNET.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNET.MVC.Controllers {
    public class SampleController : Controller {
        // GET: Sample
        public ActionResult Index(string sort, int page/*Sent with Querystring parameters to View*/) {
            return Content($"Sort: {sort}, Page: {page}");
        }

        public ActionResult Detail(int id) {
            var learn = new Learn { Id = 1, Name = "Learn" };
            var learn2 = new Learn { Id = 2, Name = "Learn2" };
            ViewData["id"] = id;
            ViewData["learn"] = learn;//Not recommended for complex types
            ViewBag.Learn2 = learn2;//Not recommended for complex types
            return View();
        }
    }
}