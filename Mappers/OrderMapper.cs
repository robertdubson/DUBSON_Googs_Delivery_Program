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

        public OrderEntity FromDomainToEntity(IOrder domainObject)
        {

            return new OrderEntity
            {
                ID = domainObject.ID,

                Product = prodMapper.FromDomainToEntity(domainObject.Product),

                Destination = destMapper.FromDomainToEntity(domainObject.Destination),

                InvolvedTransport = transportMapper.FromDomainToEntity(domainObject.InvolvedTransport),

                Time_Of_Ordering = domainObject.TimeOfOrdering,

                TimeNeededForDelivery = domainObject.TimeNeededForDelivery


            };

        }

        public OrderModel FromDomainToModel(IOrder domainObject)
        {
            return new OrderModel { ID = domainObject.ID, Destination = destMapper.FromDomainToModel(domainObject.Destination), InvolvedTransport = transportMapper.FromDomainToModel(domainObject.InvolvedTransport), Product = prodMapper.FromDomainToModel(domainObject.Product), TimeOfOrdering = domainObject.TimeOfOrdering };
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

                TimeNeededForDelivery = entityObject.TimeNeededForDelivery


            };

        }

        public IOrder FromModelToDomain(OrderModel modelObject)
        {
            return new Order { ID = modelObject.ID, Destination = destMapper.FromModelToDomain(modelObject.Destination), InvolvedTransport = transportMapper.FromModelToDomain(modelObject.InvolvedTransport), Product = prodMapper.FromModelToDomain(modelObject.Product), TimeNeededForDelivery = modelObject.TimeNeededForDelivery, TimeOfOrdering = modelObject.TimeOfOrdering};
        }
    }
}
