using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DataLib
{
    public interface IProductRepository : IRepository<ProductEntity, int>
    {
        
        IEnumerable<DeliveryTypeEntity> GetAllTypes();

        void AddNewType(DeliveryTypeEntity deliveryType);

        DeliveryTypeEntity FindTypeByID(int ID);
    }
}
