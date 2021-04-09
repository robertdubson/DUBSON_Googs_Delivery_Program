using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace DataLib
{
    public class Repository<EntityName> : IRepository<EntityName> where EntityName : class
    {
        private readonly DbContext Context;

        public Repository(DbContext context) {

            Context = context;
        
        }

        public void Add(EntityName example)
        {
            Context.Set<EntityName>().Add(example);
        }

        public void Delete(int ID)
        {
            Context.Set<EntityName>().Remove(Context.Set<EntityName>().Find(ID));
        }

        public IEnumerable<EntityName> GetAll()
        {
            return Context.Set<EntityName>();
        }

        public EntityName GetByID(int ID)
        {
            return Context.Set<EntityName>().Find(ID);
        }
    }
}
