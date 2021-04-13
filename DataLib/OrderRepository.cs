using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.Entity;
namespace DataLib
{
    public class OrderRepository : Repository<OrderEntity>, IOrderRepository
    {
        //private readonly DbContext Context;

        //DbSet<OrderEntity> _DbSet;

        public OrderRepository(DbContext context) : base(context) { 
        
            _DbSet = context.Set<OrderEntity>();
        
        }

        public void Delete(OrderEntity example)
        {
            _DbSet.Remove(example);
        }

        public OrderEntity GetByInvolvedTransport(TransportEntity transport)
        {
            return _DbSet.Find(transport);
        }
    }
        
}
