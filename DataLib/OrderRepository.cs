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

            _DbSet.Include(transport => transport.InvolvedTransport).ToList();

            _DbSet.Include(prod => prod.Product).ToList();

            _DbSet.Include(dest => dest.Destination).ToList();

        }

        

        public OrderEntity GetByInvolvedTransport(TransportEntity transport)
        {
            return _DbSet.Find(transport);
        }
    }
        
}
