using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ProductRepository : RepositoryBase<Product>
    {
        public override Product GetById(int id) {
            return this.GetAll().FirstOrDefault(x => x.ProductID == id);
        }
    }
}
