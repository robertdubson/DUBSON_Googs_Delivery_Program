using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mappers;
using Entity;
using Domain;
using DataLib;

namespace Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        OrderMapper _orderMapper;

        public OrderService(IOrderRepository repository){

            
            _orderRepository = repository;

            _orderMapper = new OrderMapper();
        
        
        
        }
        public void AddOrder(IOrder order)
        {
            _orderRepository.Add(_orderMapper.FromDomainToEntity(order));
        }

        public void DeleteOrder(int ID)
        {
            _orderRepository.Delete(ID);
        }

        public IOrder GetOrderByID(int ID)
        {
            return _orderMapper.FromEntityToDomain(_orderRepository.GetByID(ID));
        }

        public void UpdateOrder(IOrder order)
        {
            _orderRepository.Update(_orderMapper.FromDomainToEntity(order));
        }
    }
}
