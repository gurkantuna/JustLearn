using System;
using Infrastructure.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pattern.Domain.Models;

namespace Test.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ProductRepository repo = new ProductRepository();
            Product p = new Product();
            p.ProductID = 82;
            p.ProductName = "Test";
            repo.Update(p);
        }
    }
}
