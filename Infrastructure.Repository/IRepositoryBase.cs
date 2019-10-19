using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository {
    public interface IRepositoryBase<Entity> {
        List<Entity> GetAll();
        bool Insert(Entity entity);
        bool Update(Entity entity);
        bool Delete(Entity entity);
    }
}
