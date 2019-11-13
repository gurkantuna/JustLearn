using ConsoleTables;
using Pattern.Domain.Models;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.EntityFramework {

    class Program {
        static void Main(string[] args) {

            NorthwindContext db = new NorthwindContext();

            var result = from c in db.Categories
                         select new {
                             c.CategoryID,
                             c.CategoryName,
                             c.Description
                         };

            var result2 = from p in db.Products.AsEnumerable()
                          join c in db.Categories on p.CategoryID equals c.CategoryID into pc
                          from x in pc.DefaultIfEmpty()
                          select new {
                              p.ProductID,
                              p.ProductName,
                              p.Category?.CategoryName,
                              UnitPrice = string.Format("{0:n}", p.UnitPrice),
                              p.UnitsInStock
                          };

            var result3 = (from p in db.Products.AsEnumerable()
                           join c in db.Categories on p.CategoryID equals c.CategoryID
                           //into pc
                           //from x in pc.DefaultIfEmpty()
                           group p by new { c.CategoryID, c.CategoryName } into g
                           select new {
                               g.Key.CategoryID,
                               g.Key.CategoryName,
                               TotalPrice = string.Format("{0:n}", g.Sum(p => p.UnitPrice)),
                               ProductCountByCategory = g.Count()
                           }).OrderByDescending(x => x.TotalPrice);

            //This is correct of above query named result3. Because you have to write firstly orderby before string.Format()
            var result4 = from p in db.Products.AsEnumerable()
                          join c in db.Categories on p.CategoryID equals c.CategoryID
                          //into pc
                          //from x in pc.DefaultIfEmpty()
                          group p by new { c.CategoryID, c.CategoryName } into g
                          orderby g.Sum(p => p.UnitPrice) descending
                          select new {
                              g.Key.CategoryID,
                              g.Key.CategoryName,
                              TotalPrice = string.Format("{0:n}", g.Sum(p => p.UnitPrice)),
                              ProductCountByCategory = g.Count()
                          };

            var result5 = (from p in db.Products
                           select new {
                               p.ProductID,
                               p.ProductName,
                               p.UnitPrice,
                               p.UnitsInStock
                           }).OrderByDescending(p => p.UnitsInStock).ThenBy(p => p.ProductName);

            var any = db.Products.Any(p => p.UnitPrice > 0);//if exists any product greater than zero the result is true
            var all = db.Products.All(p => p.UnitPrice > 0);//if all product are greater than zero the result is true
            var paged = db.Products.Skip(10).Take(10);//you can use this methos for pagenation
            var single = db.Products.Single(x => x.ProductID == 1000);//you can use this method if you sure that the result will be one row. if not exist any product .net throws exception
            var singleOrDefault = db.Products.SingleOrDefault(x => x.CategoryID == 1);//you can use this method if you sure that the result will be one row. Otherwise .net throws exception
            var first = db.Products.First(x => x.ProductID == 1000);//you can use this method if you sure that at least one result. Otherwise .net throws exception
            var firstOrDefault = db.Products.FirstOrDefault(x => x.ProductID == 1000);//you can use this method in every situation

            ConsoleTable.From(result5).Write();

            Console.Read();
        }
    }
}
