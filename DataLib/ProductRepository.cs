using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DataLib
{
    public class ProductRepository : IProductRepository
    {
        public List<ProductEntity> EntitiesFromDataSourse { get; set; }
        public List<DeliveryTypeEntity> typesOfDelivery { get; set; }

        public void Add(ProductEntity example)
        {
            EntitiesFromDataSourse.Add(example);
        }

        public void Delete(int ID)
        {
            EntitiesFromDataSourse.Remove(EntitiesFromDataSourse.Find(product => product.ID == ID));

        }

        public List<DeliveryTypeEntity> GetAllTypes()
        {
            return typesOfDelivery;
        }

        public ProductEntity GetByID(int ID)
        {
            return EntitiesFromDataSourse.Find(product => product.ID == ID);
        }

        public void Update(ProductEntity example)
        {
            EntitiesFromDataSourse.Remove(EntitiesFromDataSourse.Find(product => product.ID == example.ID));
            EntitiesFromDataSourse.Add(example);
        }
    }
}
