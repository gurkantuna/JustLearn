using JustLearn.DTO;
using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SOA.WebService {
    /// <summary>
    /// Summary description for ProductWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ProductWebService : System.Web.Services.WebService {

        private static NorthwindContext _context;

        public static NorthwindContext DbContext {
            get {
                _context = _context ?? new NorthwindContext();
                return _context;
            }
            set { _context = value; }
        }

        [WebMethod]
        public List<ProductDTO> GetProducts() {
            var query = from p in DbContext.Products
                        select new ProductDTO//You can use AutoMapper NuGet package for this. I will show you in WCFService project.
                        {
                            ProductID = p.ProductID,
                            ProductName = p.ProductName,
                            CategoryID = p.CategoryID,
                            CategoryName = p.Category.CategoryName,
                            Discontinued = p.Discontinued,
                            UnitPrice = p.UnitPrice,
                            UnitsInStock = p.UnitsInStock
                        };

            return query.ToList();
        }
    }
}
