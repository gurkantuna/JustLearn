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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductWCFService" in both code and config file together.
    [ServiceContract]
    public interface IProductWCFService : IServiceBase<ProductDTO, Product>
    {
        [OperationContract]
        ProductDTO GetById(int id);

        [OperationContract]
        Product GetEntityById(int id);
    }
}
