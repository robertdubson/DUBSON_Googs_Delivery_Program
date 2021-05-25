using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLib
{
    public interface IRepository<TEntity, TKey>
    {
        //List<EntityName> Context { get; set; }

        IEnumerable<TEntity> GetAll();
               
        void Add(TEntity example);

        TEntity GetByID(TKey ID);

        void Update(TEntity example);

        void Delete(TKey ID);

        void Delete(TEntity example);

    }
}
