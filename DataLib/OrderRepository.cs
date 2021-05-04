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

            _DbSet.Include(order => order.InvolvedTransport).ToList();

            _DbSet.Include(order => order.Product).ToList();

            _DbSet.Include(order => order.Destination).ToList();

            _DbSet.Include(order => order.OrderStatus).ToList();

        }

        

        public OrderEntity GetByInvolvedTransport(TransportEntity transport)
        {
            return _DbSet.Find(transport);
        }
    }
        
}
