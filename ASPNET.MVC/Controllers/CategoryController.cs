using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNET.MVC.Controllers {
    public class CategoryController : Controller {
        NorthwindContext db = new NorthwindContext();

        // GET: Category
        public ActionResult Index() {
            var categories = db.Categories.ToList();
            return View(categories);
        }

        public ActionResult New() {
            return View(new Category());
        }

        [HttpPost]
        public ActionResult New(Category c) {
            db.Categories.Add(c);
            db.SaveChanges();

            return RedirectToAction("Index");

        }

        [HttpPost]
        public ActionResult Delete(int id) {
            var model = db.Categories.Find(id);
            if (model == null) {
                return HttpNotFound();
            }

            db.Categories.Remove(model);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult ShowProducts(int id) {
            var model = db.Products.Where(p => p.CategoryID == id).ToList();
            return PartialView(model);
        }

        //For db images
        private Image ByteArrayToImage(byte[] byteArrayIn) {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}