using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLib
{
    public interface IRepository<EntityName>
    {
        //List<EntityName> Context { get; set; }

        IEnumerable<EntityName> GetAll();
        
        
        void Add(EntityName example);

        EntityName GetByID(int ID);

        void Update(EntityName example);

        void Delete(int ID);

        

    }
}
