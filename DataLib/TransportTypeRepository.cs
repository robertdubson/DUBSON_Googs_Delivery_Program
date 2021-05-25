using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace DataLib
{
    public class TransportTypeRepository :  Repository<TransportTypeEntity, int>, ITransportTypeRepository
    {
        public TransportTypeRepository(DbContext context) : base(context) { 
        
        
        }
    }
}
