using ASPNET.WebAPI.Attributes;
using ASPNET.WebAPI.Security;
using Infrastructure.Repository;
using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace ASPNET.WebAPI.Controllers {

    //[APIAuthorize(Roles = "Admin,Moderator")]
    //[ApiException] Move ftom controller level to App_Start/WebApiConfig.Register(config.Filters.Add(new ApiExceptionAttribute()));
    public class ProductController : ApiController {

        ProductRepository rep = new ProductRepository();

        //[Authorize]
        //[APIAuthorize(Roles = "Admin,Moderator")]
        [ResponseType(typeof(IEnumerable<Product>))]
        public HttpResponseMessage Get() {
            var products = rep.GetAll();
            return Request.CreateResponse(HttpStatusCode.OK, products);
        }

        /*
         * This method is the same with above method        

        [HttpGet]
        public HttpResponseMessage AllLanguages() {
            var products = rep.GetAll();
            return Request.CreateResponse(HttpStatusCode.OK, products);
        }
        */

        /*
         * This methos is not useful because of handle an error with try-catch blocks for each method. We will use below method(ExceptionFilterAttribute)
         * 
        [ResponseType(typeof(Product))]
        public IHttpActionResult  Get(int id) {
            try {
                //int a = 1, b = 0;
                //var c = a / b;

                var p = rep.GetById(id);
                if (p == null) {
                    //return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No record");
                    //return NotFound();
                    //return StatusCode(HttpStatusCode.NotFound);
                    return Content(HttpStatusCode.NotFound, "No Record");
                }

                //return Request.CreateResponse(HttpStatusCode.OK, p);
                return Ok(p);//Using instead of above row
            }
            catch (Exception ex) {

                HttpResponseMessage responseMessage = new HttpResponseMessage(HttpStatusCode.BadGateway);
                responseMessage.ReasonPhrase = ex.Message;
                throw new HttpResponseException(responseMessage);
            }
        }
        */

        //[ApiException] Move from action level to controller level
        [ResponseType(typeof(Product))]
        public IHttpActionResult Get(int id) {

            int a = 1, b = 0;
            var c = a / b;

            var p = rep.GetById(id);
            if (p == null) {
                //return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No record");
                //return NotFound();
                //return StatusCode(HttpStatusCode.NotFound);
                return Content(HttpStatusCode.NotFound, "No Record");
            }

            //return Request.CreateResponse(HttpStatusCode.OK, p);
            return Ok(p);//Using instead of above row
        }

        public IHttpActionResult Post(Product p) {
            if (ModelState.IsValid) {
                rep.Insert(p);
                //return Request.CreateResponse(HttpStatusCode.Created, p);
                return CreatedAtRoute("DefaultApi", new { id = p.ProductID }, p);//Using instead of above row
            }
            else {
                //return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                return BadRequest(ModelState);//Using instead of above row
            }
        }

        public IHttpActionResult Put(int id, Product newVal) {
            var p = rep.GetById(id);
            if (p == null) {
                return Content(HttpStatusCode.NotFound, "No Record.");
            }

            if (ModelState.IsValid) {
                rep.Update(newVal);
                return Ok(newVal);
            }
            else {
                return BadRequest(ModelState);
            }
        }

        public IHttpActionResult Delete(int id) {
            var p = rep.GetById(id);
            if (p == null) {
                return Content(HttpStatusCode.NotFound, "No Record.");
            }

            if (ModelState.IsValid) {
                Product delProd = rep.GetById(id);
                rep.Delete(delProd);
                return Ok(delProd);
            }
            else {
                return BadRequest(ModelState);
            }
        }

        //This method is not public for API with [NonAction]
        [NonAction]
        public IHttpActionResult Foo() {
            return Content(HttpStatusCode.NotFound, "No Record");
        }

        [HttpGet]
        public IHttpActionResult /*Get*/SearchByName(string name) {
            return Ok($"Name: {name}");
        }

        [HttpGet]
        public IHttpActionResult /*Get*/SearchByLastName(string name, string lastName) {
            return Ok($"Name: {name}, LastName: {lastName}");
        }
    }
}
