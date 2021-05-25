using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.Entity;
namespace DataLib
{
    public class OrderStatusRepository : Repository<OrderStatusEntity, int>, IOrderStatusRepository
    {
        public OrderStatusRepository(DbContext context) : base(context) { 
        
        
        }
    }
}
