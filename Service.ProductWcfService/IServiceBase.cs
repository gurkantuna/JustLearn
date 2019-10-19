using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Service.ProductWcfService {
    [ServiceContract]
    public interface IServiceBase<DTO,Entity> {

        [OperationContract]
        List<DTO> GetAll();

        [OperationContract]
        List<Entity> GetEntities();

        [OperationContract]
        bool Insert(DTO dto);

        [OperationContract]
        bool Update(DTO dto);

        [OperationContract]
        bool UpdateEntity(Entity entity);

        [OperationContract]
        bool Delete(DTO dto);        
    }
}
