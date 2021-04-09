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
        private readonly DbContext Context;


        public OrderRepository(DbContext context) : base(context) { }

        public void Delete(OrderEntity example)
        {
            Context.Set<OrderEntity>().Remove(example);
        }

        public OrderEntity GetByInvolvedTransport(TransportEntity transport)
        {
            return Context.Set<OrderEntity>().Find(transport);
        }
    }
        
}
