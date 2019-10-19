using Infrastructure.Repository;
using JustLearn.DTO;
using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service.ProductWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductWCFService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductWCFService.svc or ProductWCFService.svc.cs at the Solution Explorer and start debugging.
    public class ProductWCFService : ServiceBase<ProductRepository, Product, ProductDTO>, IProductWCFService
    {


        public ProductDTO GetById(int id) {
            return this.GetAll().FirstOrDefault(x => x.ProductID == id);
        }

        public Product GetEntityById(int id) {
            var entities = this.GetEntities();
            var product = entities.FirstOrDefault(x => x.ProductID == id);
            return product;
        }
    }
}
