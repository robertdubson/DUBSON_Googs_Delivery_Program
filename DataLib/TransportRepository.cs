using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace DataLib
{
    public class TransportRepository : ITransportRepository
    {
        public List<TransportEntity> EntitiesFromDataSourse { get; set; }

        //List<TransportEntity> IRepository<TransportEntity>.EntitiesFromDataSourse { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(TransportEntity example)
        {
            EntitiesFromDataSourse.Add(example);
        }

        public void Delete(int ID)
        {
            EntitiesFromDataSourse.Remove(EntitiesFromDataSourse.Find(transport => transport.ID == ID));
        }

        public TransportEntity GetByID(int ID)
        {
            return EntitiesFromDataSourse.Find(transport => transport.ID == ID);
        }

        public void Update(TransportEntity example)
        {
            EntitiesFromDataSourse.Remove(EntitiesFromDataSourse.Find(transport => transport.ID == example.ID));
            EntitiesFromDataSourse.Add(example);
        }
    }
}
