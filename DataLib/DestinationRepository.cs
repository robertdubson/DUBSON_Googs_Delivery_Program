using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entity;
using System.Data.Entity;

namespace DataLib
{
    public class DestinationRepository : Repository<DestinationEntity>, IDestinationRepository
    {
        //public List<DestinationEntity> Context { get; set; }

        

        public DestinationRepository(DbContext context) : base(context) { 
        

        
        }

        

       
    }
}
