using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.Entity;
namespace DataLib
{
    public class ProductRepository : Repository<ProductEntity>, IProductRepository
    {
        //public List<ProductEntity> Context { get; set; }

        

        IEnumerable<DeliveryTypeEntity> typesOfDelivery;

        public ProductRepository(DbContext context) : base(context) {

            _DbSet = context.Set<ProductEntity>();

            typesOfDelivery = context.Set<DeliveryTypeEntity>();
        
        }

        public void AddNewType(DeliveryTypeEntity deliveryType)
        {
            typesOfDelivery.ToList().Add(deliveryType);
        }

        public IEnumerable<DeliveryTypeEntity> GetAllTypes()
        {
            return typesOfDelivery;
        }

        
       
    }
}
