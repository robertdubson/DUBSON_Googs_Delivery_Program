using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entity;


namespace DataLib
{
    public class DestinationRepository : Repository<DestinationEntity>, IDestinationRepository
    {
        //public List<DestinationEntity> Context { get; set; }

        

        public DestinationRepository(DbContext context) : base(context) {

            _DbSet = context.Set<DestinationEntity>();
        
        }

        

       
    }
}
