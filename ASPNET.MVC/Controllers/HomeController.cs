using ASPNET.MVC.Models;
using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNET.MVC.Controllers {
    public class HomeController : Controller {

        //Not recommended
        public string HelloWorld() {
            return "Hello World1";
        }

        //Not recommended
        public string HelloWorld2() {
            return "<h1>Hello World2</h1>";
        }

        // GET: Home
        public ActionResult Index() {
            return View();
        }

        public ActionResult RedirectToAction() {
            return RedirectToAction("Index", routeValues: new { SortBy = "Id" });//routeValues creates a Querystring
        }

        public ActionResult Redirect() {
            return new RedirectResult("/Home/Index");
        }

        public ActionResult /*ContentResult*/ HelloWorld3() {
            return Content("Hello World3");
        }

        public ActionResult /*FileResult*/File() {
            return File("~/Views/Home/sampleFile.txt", "text/plain");
        }

        public ActionResult NotFound() {
            return HttpNotFound();
        }

        public ActionResult Unauthorized() {
            return new HttpUnauthorizedResult();
        }

        public ActionResult Json() {
            Learn learn = new Learn { Id = 1, Name = "JohnDoe" };
            return Json(learn, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Empty() {
            return new EmptyResult();
        }

        /*
         * You have to use id for parameter name by RouteConfig settings.
         * You can send a different name with [RouteAttriube]
         *  
         * Or you can send a different name if you create another route but this is not useful according to attribute usage
         * routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        */
        public ActionResult GetSample(int id) {
            return Content($"Sent id:{id}");
        }

        //Not recommended. You should use a single class instead of different parameter
        public ActionResult Update(int sampleId, string name) {
            return Content($"SampleId: {sampleId}, Name: {name}");
        }

        //Firstly routes.MapMvcAttributeRoutes(); in RouteConfig.cs
        [Route("Person/List/{sort}/{page}")]
        public ActionResult GetAllPerson(string sort, int page) {
            return Content($"Sort: {sort}, Page: {page}");
        }

        // GET: Home/Sample2
        // This is not working with Home/Sample3
        [ActionName("Sample2")]
        public ActionResult Sample3() {
            return Content("ActionName : Sample2 MethodName : Sample3");
        }
    }
}