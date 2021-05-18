using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib;
using Mappers;
using DataLib.UnitOfWork;
namespace Services
{
    public class OrderStatusService : IOrderStatusService
    {
        OrderStatusMapper _orderStatusMapper;

        IUnitOfWork _unitOfWork;

        public OrderStatusService(IUnitOfWork unitOfWork) {

            _unitOfWork = unitOfWork;

            _orderStatusMapper = new OrderStatusMapper();

        }

        public void AddStatus(OrderStatus status)
        {
            _unitOfWork.OrderStatusRepository.Add(_orderStatusMapper.FromDomainToEntity(status));
        }

        public void DeleteStatus(int ID)
        {
            _unitOfWork.OrderStatusRepository.Delete(ID);
        }

        public IEnumerable<OrderStatus> GetAllStatuses()
        {
            return _unitOfWork.OrderStatusRepository.GetAll().ToList().Select(ordStatus => _orderStatusMapper.FromEntityToDomain(ordStatus));
        }

        public OrderStatus GetStatusByID(int ID)
        {
            return _orderStatusMapper.FromEntityToDomain(_unitOfWork.OrderStatusRepository.GetByID(ID));
        }

        public void UpdateStatus(OrderStatus status)
        {
            _unitOfWork.OrderStatusRepository.Update(_orderStatusMapper.FromDomainToEntity(status));
        }
    }
}
