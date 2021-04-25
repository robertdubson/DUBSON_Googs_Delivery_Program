using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mappers;
using Entity;
using Domain;
using DataLib;
using Services.Strategy;

namespace Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        OrderMapper _orderMapper;

        TransportMapper _transportMapper;

        public OrderService(IOrderRepository repository){

            
            _orderRepository = repository;

            _orderMapper = new OrderMapper();

            _transportMapper = new TransportMapper();
        
        
        
        }
        public void AddOrder(IOrder order)
        {
            _orderRepository.Add(_orderMapper.FromDomainToEntity(order));
        }

        public void DeleteOrder(int ID)
        {
            _orderRepository.Delete(ID);
        }

        public void DeleteOrder(IOrder order)
        {
            _orderRepository.Delete(_orderMapper.FromDomainToEntity(order));
        }

        public IOrder GetOrderByID(int ID)
        {
            return _orderMapper.FromEntityToDomain(_orderRepository.GetByID(ID));
        }

        public IOrder GetOrderByInvolvedTransport(ITransport transport) {

            return _orderMapper.FromEntityToDomain(_orderRepository.GetByInvolvedTransport(_transportMapper.FromDomainToEntity(transport)));       
        
        }

       
        public List<IOrder> GetAllOrders() {

            return _orderRepository.GetAll().Select(ord => _orderMapper.FromEntityToDomain(ord)).ToList();
        
        }

        

        public IOrder CreateAnOrder(IDestination destination, IProduct product, List<ITransport> suitableTransport) {

            Func<ITransport, IOrder> getOrderByTransport = GetOrderByInvolvedTransport;

            StrategyContext strategyContext = new StrategyContext(new StandartLogic());

            if (!suitableTransport.Select(transport => transport.InTheShop).Any())
            {
 
                strategyContext.CurrentStrategy = new NoTransportLogic();

                IOrder newOrder = strategyContext.CurrentStrategy.CreateAnOrder(destination, product, suitableTransport, getOrderByTransport);
                
                AddOrder(newOrder);

                return newOrder;

            }
            else {

                IOrder newOrder = strategyContext.CurrentStrategy.CreateAnOrder(destination, product, suitableTransport, getOrderByTransport);

                AddOrder(newOrder);

                return newOrder;
            
            }
        
        }

        

    }
}
