using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

using System.Data.Entity;

namespace DataLib
{
    public class DeliveryTypeRepository :  Repository<DeliveryTypeEntity, int>, IDeliveryTypeRepository
    {
        public DeliveryTypeRepository(DbContext context) : base(context) { 
        
        
        }
    }
}
