using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace DataLib
{
    public class OrderRepository : IRepository<OrderEntity>
    {
        public List<OrderEntity> EntitiesFromDataSourse { get; set; }
        public void Add(OrderEntity example)
        {
            EntitiesFromDataSourse.Add(example);
        }

        public void Delete(int ID)
        {
            EntitiesFromDataSourse.Remove(EntitiesFromDataSourse.Find(order => order.ID == ID));
        }

        public OrderEntity GetByID(int ID)
        {
            return EntitiesFromDataSourse.Find(order => order.ID == ID);
        }

        public void Update(OrderEntity example)
        {
            EntitiesFromDataSourse.Remove(EntitiesFromDataSourse.Find(order => order.ID == example.ID));
            EntitiesFromDataSourse.Add(example);
        }
    }
}
