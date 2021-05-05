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
        public void AddOrder(Order order)
        {
            _orderRepository.Add(_orderMapper.FromDomainToEntity(order));
        }

        public void DeleteOrder(int ID)
        {
            _orderRepository.Delete(ID);
        }

        public void DeleteOrder(Order order)
        {
            _orderRepository.Delete(_orderMapper.FromDomainToEntity(order));
        }

        public Order GetOrderByID(int ID)
        {
            return _orderMapper.FromEntityToDomain(_orderRepository.GetByID(ID));
        }

        public Order GetOrderByInvolvedTransport(Transport transport) {

            return _orderMapper.FromEntityToDomain(_orderRepository.GetByInvolvedTransport(_transportMapper.FromDomainToEntity(transport)));       
        
        }

       
        public List<Order> GetAllOrders() {

            return _orderRepository.GetAll().Select(ord => _orderMapper.FromEntityToDomain(ord)).ToList();
        
        }

        

        public Order CreateAnOrder(Destination destination, Product product, List<Transport> suitableTransport) {

            Func<Transport, Order> getOrderByTransport = GetOrderByInvolvedTransport;

            StrategyContext strategyContext = new StrategyContext(new StandartLogic());

            if (!suitableTransport.Select(transport => transport.InTheShop).Any())
            {
 
                strategyContext.CurrentStrategy = new NoTransportLogic();

                Order newOrder = strategyContext.CurrentStrategy.CreateAnOrder(destination, product, suitableTransport, getOrderByTransport);

                newOrder.Status = new OrderStatus() { ID = 0, Status = "В обробці" };
                
                //AddOrder(newOrder);


                return newOrder;

            }
            else {

                Order newOrder = strategyContext.CurrentStrategy.CreateAnOrder(destination, product, suitableTransport, getOrderByTransport);

                newOrder.Status = new OrderStatus() { ID = 0, Status = "В обробці" };

                //AddOrder(newOrder);

                return newOrder;
            
            }
        
        }

        

    }
}
