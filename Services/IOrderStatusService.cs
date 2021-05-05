using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Mappers;
namespace Services
{
    public interface IOrderStatusService
    {
        IEnumerable<OrderStatus> GetAllStatuses();

        void DeleteStatus(int ID);

        OrderStatus GetStatusByID(int ID);

        void AddStatus(OrderStatus status);

        void UpdateStatus(OrderStatus status);

        
    }
}
