using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Entity;
using Domain;
namespace Mappers
{
    public class OrderStatusMapper : IMapper<OrderStatusEntity, IOrderStatus, OrderStatusModel>
    {
        public OrderStatusEntity FromDomainToEntity(IOrderStatus domainObject)
        {
            return new OrderStatusEntity() { ID = domainObject.ID, Status = domainObject.Status };
        }

        public OrderStatusModel FromDomainToModel(IOrderStatus domainObject)
        {
            return new OrderStatusModel() { ID = domainObject.ID, Status = domainObject.Status };
        }

        public IOrderStatus FromEntityToDomain(OrderStatusEntity entityObject)
        {
            return new OrderStatus() { ID = entityObject.ID, Status = entityObject.Status };
        }

        public IOrderStatus FromModelToDomain(OrderStatusModel modelObject)
        {
            return new OrderStatus() { ID = modelObject.ID, Status = modelObject.Status };
        }
    }
}
