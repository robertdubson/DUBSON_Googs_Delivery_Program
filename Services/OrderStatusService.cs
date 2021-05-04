using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib;
using Mappers;
namespace Services
{
    public class OrderStatusService : IOrderStatusService
    {
        private readonly IOrderStatusRepository OrderStatusRepository;

        OrderStatusMapper _orderStatusMapper;

        public OrderStatusService(IOrderStatusRepository repository) {

            OrderStatusRepository = repository;

            _orderStatusMapper = new OrderStatusMapper();
        
        }

        public void AddStatus(IOrderStatus status)
        {
            OrderStatusRepository.Add(_orderStatusMapper.FromDomainToEntity(status));
        }

        public void DeleteStatus(int ID)
        {
            OrderStatusRepository.Delete(ID);
        }

        public IEnumerable<IOrderStatus> GetAllStatuses()
        {
            return OrderStatusRepository.GetAll().ToList().Select(ordStatus => _orderStatusMapper.FromEntityToDomain(ordStatus));
        }

        public IOrderStatus GetStatusByID(int ID)
        {
            return _orderStatusMapper.FromEntityToDomain(OrderStatusRepository.GetByID(ID));
        }

        public void UpdateStatus(IOrderStatus status)
        {
            OrderStatusRepository.Update(_orderStatusMapper.FromDomainToEntity(status));
        }
    }
}
