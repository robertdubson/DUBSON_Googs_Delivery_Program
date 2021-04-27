using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLib.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IDestinationRepository DestinationRepository { get; }

        IProductRepository ProductRepository { get; }

        IOrderRepository OrderRepository { get; }

        ITransportRepository TransportRepository { get; }

        IDeliveryTypeRepository DeliveryTypeRepository { get; }

        ITransportTypeRepository TransportTypeRepository { get; }

        int Complete();
    }
}
