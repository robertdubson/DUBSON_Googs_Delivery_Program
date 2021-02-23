using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace DataLib
{
    public class DestinationRepository : IDestinationRepository
    {
        public List<DestinationEntity> EntitiesFromDataSourse { get; set; }
        
        public void Add(DestinationEntity example)
        {
            EntitiesFromDataSourse.Add(example);
        }

        public void Delete(int ID)
        {
            EntitiesFromDataSourse.Remove(EntitiesFromDataSourse.Find(dest => dest.ID == ID));
        }

        public DestinationEntity GetByID(int ID)
        {
            return EntitiesFromDataSourse.Find(dest => dest.ID == ID);
        }

        public void Update(DestinationEntity example)
        {
            EntitiesFromDataSourse.Remove(EntitiesFromDataSourse.Find(dest => dest.ID == example.ID));
            EntitiesFromDataSourse.Add(example);
        }

        
    }
}
