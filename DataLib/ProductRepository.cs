using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.Entity;
namespace DataLib
{
    public class ProductRepository : Repository<ProductEntity, int>, IProductRepository
    {
        //public List<ProductEntity> Context { get; set; }

        

        DbSet<DeliveryTypeEntity> typesOfDelivery;

        public ProductRepository(DbContext context) : base(context) {

            _DbSet = context.Set<ProductEntity>();

            typesOfDelivery = context.Set<DeliveryTypeEntity>();

            _DbSet.Include(prod => prod.DeliveryType).ToList();
        
        }

        public void AddNewType(DeliveryTypeEntity deliveryType)
        {
            //typesOfDelivery.Attach(deliveryType);
            typesOfDelivery.Add(deliveryType);
        }

        public DeliveryTypeEntity FindTypeByID(int ID)
        {
            return typesOfDelivery.Find(ID);
        }

        public IEnumerable<DeliveryTypeEntity> GetAllTypes()
        {
            return typesOfDelivery;
        }

        
       
    }
}
