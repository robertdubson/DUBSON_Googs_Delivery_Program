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
using DataLib.UnitOfWork;

namespace Services
{
    public class OrderService : IOrderService
    {
        

        OrderMapper _orderMapper;

        TransportMapper _transportMapper;

        IUnitOfWork _unitOfWork;

        public OrderService(IUnitOfWork unitOfWork) {

            _unitOfWork = unitOfWork;

            _transportMapper = new TransportMapper();

        }

        public void AddOrder(Order order)
        {
            _unitOfWork.OrderRepository.Add(_orderMapper.FromDomainToEntity(order));
        }

        public void DeleteOrder(int ID)
        {
            _unitOfWork.OrderRepository.Delete(ID);
        }

        public void DeleteOrder(Order order)
        {
            _unitOfWork.OrderRepository.Delete(_orderMapper.FromDomainToEntity(order));
        }

        public Order GetOrderByID(int ID)
        {
            return _orderMapper.FromEntityToDomain(_unitOfWork.OrderRepository.GetByID(ID));
        }

        public Order GetOrderByInvolvedTransport(Transport transport) {

            return _orderMapper.FromEntityToDomain(_unitOfWork.OrderRepository.GetByInvolvedTransport(_transportMapper.FromDomainToEntity(transport)));       
        
        }

       
        public List<Order> GetAllOrders() {

            return _unitOfWork.OrderRepository.GetAll().Select(ord => _orderMapper.FromEntityToDomain(ord)).ToList();
        
        }

        

        public Order CreateAnOrder(Destination destination, Product product, List<Transport> suitableTransport) {

            Func<Transport, Order> getOrderByTransport = GetOrderByInvolvedTransport;

            StrategyContext strategyContext = new StrategyContext(new StandartLogic());

            if (!suitableTransport.Select(transport => transport.InTheShop).Any())
            {
 
                strategyContext.CurrentStrategy = new NoTransportLogic();

                Order newOrder = strategyContext.CurrentStrategy.ProcessTheOrder(destination, product, suitableTransport, getOrderByTransport);

                newOrder.Status = new OrderStatus() { ID = 0, Status = "В обробці" };

                return newOrder;

            }
            else {

                Order newOrder = strategyContext.CurrentStrategy.ProcessTheOrder(destination, product, suitableTransport, getOrderByTransport);

                newOrder.Status = new OrderStatus() { ID = 0, Status = "В обробці" };

                //AddOrder(newOrder);

                return newOrder;
            
            }
        
        }

        

    }
}
