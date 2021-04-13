using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.Entity;
namespace DataLib
{
    public class TransportRepository : Repository<TransportEntity>, ITransportRepository
    {
        

        public TransportRepository(DbContext context) : base(context) {

            _DbSet = context.Set<TransportEntity>();
        
        }


        //List<TransportEntity> IRepository<TransportEntity>.Context { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        

        

    }
}
