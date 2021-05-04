using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Domain;
using Model;

namespace Mappers
{
    public class OrderMapper : IMapper<OrderEntity, IOrder, OrderModel>
    {
        DestinationMapper destMapper = new DestinationMapper();

        ProductMapper prodMapper = new ProductMapper();

        TransportMapper transportMapper = new TransportMapper();

        OrderStatusMapper orderStatusMapper = new OrderStatusMapper();

        public OrderEntity FromDomainToEntity(IOrder domainObject)
        {

            return new OrderEntity
            {
                ID = domainObject.ID,

                Product = prodMapper.FromDomainToEntity(domainObject.Product),

                Destination = destMapper.FromDomainToEntity(domainObject.Destination),

                InvolvedTransport = transportMapper.FromDomainToEntity(domainObject.InvolvedTransport),

                Time_Of_Ordering = domainObject.TimeOfOrdering,

                TimeNeededForDelivery = domainObject.TimeNeededForDelivery,

                OrderStatus = orderStatusMapper.FromDomainToEntity(domainObject.Status)


            };

        }

        public OrderModel FromDomainToModel(IOrder domainObject)
        {
            return new OrderModel { ID = domainObject.ID, Destination = destMapper.FromDomainToModel(domainObject.Destination), InvolvedTransport = transportMapper.FromDomainToModel(domainObject.InvolvedTransport), Product = prodMapper.FromDomainToModel(domainObject.Product), TimeOfOrdering = domainObject.TimeOfOrdering, TimeNeededForDelivery = domainObject.TimeNeededForDelivery, Status = orderStatusMapper.FromDomainToModel(domainObject.Status) };
        }

        public IOrder FromEntityToDomain(OrderEntity entityObject)
        {

            return new Order()
            {
                ID = entityObject.ID,

                Product = prodMapper.FromEntityToDomain(entityObject.Product),

                Destination = destMapper.FromEntityToDomain(entityObject.Destination),

                InvolvedTransport = transportMapper.FromEntityToDomain(entityObject.InvolvedTransport),

                TimeOfOrdering = entityObject.Time_Of_Ordering,

                TimeNeededForDelivery = entityObject.TimeNeededForDelivery,

                Status = orderStatusMapper.FromEntityToDomain(entityObject.OrderStatus)


            };

        }

        public IOrder FromModelToDomain(OrderModel modelObject)
        {
            return new Order { ID = modelObject.ID, Destination = destMapper.FromModelToDomain(modelObject.Destination), InvolvedTransport = transportMapper.FromModelToDomain(modelObject.InvolvedTransport), Product = prodMapper.FromModelToDomain(modelObject.Product), TimeNeededForDelivery = modelObject.TimeNeededForDelivery, TimeOfOrdering = modelObject.TimeOfOrdering, Status = orderStatusMapper.FromModelToDomain(modelObject.Status)};
        }
    }
}
