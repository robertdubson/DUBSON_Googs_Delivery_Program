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

        public DbSet<EntityName> _DbSet;

        public Repository(DbContext context) {

            Context = context;

            _DbSet = Context.Set<EntityName>();
        
        }

        public void Add(EntityName example)
        {
            //_DbSet.Attach(example);
            _DbSet.Add(example);
        }

        public void Delete(int ID)
        {
            _DbSet.Remove(Context.Set<EntityName>().Find(ID));
        }

        public void Delete(EntityName example)
        {
            Context.Entry(example).State = EntityState.Deleted;
            Context.SaveChanges();
        }

        public IEnumerable<EntityName> GetAll()
        {
            return _DbSet;
        }

        public EntityName GetByID(int ID)
        {
            return _DbSet.Find(ID);
        }

        public void Update(EntityName example)
        {
            Context.Entry(example).State = EntityState.Modified;
            Context.SaveChanges();
        }
    }
}
