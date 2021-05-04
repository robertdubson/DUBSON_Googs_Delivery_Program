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
        IEnumerable<IOrderStatus> GetAllStatuses();

        void DeleteStatus(int ID);

        IOrderStatus GetStatusByID(int ID);

        void AddStatus(IOrderStatus status);

        void UpdateStatus(IOrderStatus status);

        
    }
}
