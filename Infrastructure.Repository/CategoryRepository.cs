using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository {
    class CategoryRepository : RepositoryBase<Category>
    {
        //public override Category GetById(int id) {
        //    return this.GetAll().FirstOrDefault(x => x.CategoryID == id);
        //}
        public override Category GetById(int id) {
            throw new NotImplementedException();
        }
    }
}
