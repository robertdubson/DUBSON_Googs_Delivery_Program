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
    public class OrderStatusMapper : IMapper<OrderStatusEntity, OrderStatus, OrderStatusModel>
    {
        public OrderStatusEntity FromDomainToEntity(OrderStatus domainObject)
        {
            return new OrderStatusEntity() { ID = domainObject.ID, Status = domainObject.Status };
        }

        public OrderStatusModel FromDomainToModel(OrderStatus domainObject)
        {
            return new OrderStatusModel() { ID = domainObject.ID, Status = domainObject.Status };
        }

        public OrderStatus FromEntityToDomain(OrderStatusEntity entityObject)
        {
            return new OrderStatus() { ID = entityObject.ID, Status = entityObject.Status };
        }

        public OrderStatus FromModelToDomain(OrderStatusModel modelObject)
        {
            return new OrderStatus() { ID = modelObject.ID, Status = modelObject.Status };
        }
    }
}
