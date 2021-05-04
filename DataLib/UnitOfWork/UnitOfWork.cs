using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace DataLib.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        public UnitOfWork(DbContext context) {

            _context = context;

            DestinationRepository = new DestinationRepository(_context);

            ProductRepository = new ProductRepository(_context);

            OrderRepository = new OrderRepository(_context);

            TransportRepository = new TransportRepository(_context);

            DeliveryTypeRepository = new DeliveryTypeRepository(_context);

            TransportTypeRepository = new TransportTypeRepository(_context);

            OrderStatusRepository = new OrderStatusRepository(_context);
        
        }

        public IDestinationRepository DestinationRepository { get; private set; }

        public IProductRepository ProductRepository { get; private set; }

        public IOrderRepository OrderRepository { get; private set; }

        public ITransportRepository TransportRepository { get; private set; }

        public IDeliveryTypeRepository DeliveryTypeRepository { get; private set; }

        public ITransportTypeRepository TransportTypeRepository { get; private set; }

        public IOrderStatusRepository OrderStatusRepository { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
