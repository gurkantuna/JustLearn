using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ASPNET.MVC.Helpers;
using ASPNET.MVC.ViewModels;

namespace ASPNET.MVC.Controllers {
    public class ProductController : Controller {
        NorthwindContext db = new NorthwindContext();

        // GET: Product
        //[Authorize]
        [OutputCache(Duration = 30)]        
        public ActionResult Index() {
            //var model = db.Products.ToList();//This can works only with LazyLoading
            var model = db.Products.Include(p => p.Category).ToList();//using System.Data.Entity;
            return View(model);
        }

        //[Authorize(Roles = "Admin,Moderator")]
        public ActionResult New() {
            return View("ProductForm", new Product());//We sent an empty Product object for Product.Id hidden field
        }

        [HttpPost]
        [ValidateAntiForgeryToken]//Cross Side Request Forgery(CSRF)
        public ActionResult Save(Product p) {
            if (!ModelState.IsValid) {
                return View("ProductForm");
            }

            MessageViewModel messageModel = new MessageViewModel();

            if (p.ProductID == 0) {
                db.Products.Add(p);
                messageModel.Message = $"{p.ProductName} product is added succesfully";
            }
            else {
                //db.Entry(p).State = System.Data.Entity.EntityState.Modified; 
                var updateProduct = db.Products.Find(p.ProductID);
                if (updateProduct == null) {
                    return HttpNotFound();
                }
                updateProduct.ProductName = p.ProductName;
                messageModel.Message = $"{p.ProductName} product is updated succesfully";
            }

            messageModel.IsSuccess = true;
            messageModel.Url = "/Product";
            messageModel.LinkText = "Product List";
            db.SaveChanges();
            //return RedirectToAction("Index");
            return PartialView("_Message", messageModel);
        }

        public ActionResult Update(int id) {
            var model = db.Products.Find(id);
            if (model == null) {
                return HttpNotFound();
            }
            return View("ProductForm", model);
        }

        public ActionResult Delete(int id) {

            var model = db.Products.Find(id);
            if (model == null) {
                return HttpNotFound();
            }

            db.Products.Remove(model);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public string TotalPrice() {
            return string.Format("{0:n}", db.Products.Sum(x => x.UnitPrice));
        }

        //You can use this method also instead od above method
        //public ActionResult TotalPrice() {
        //    ViewBag.TotalPrice = string.Format("{0:n}", db.Products.Sum(x => x.UnitPrice));
        //    return PartialView();
        //}
    }
}