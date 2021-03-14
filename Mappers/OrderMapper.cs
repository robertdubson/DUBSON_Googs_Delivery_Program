using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Domain;

namespace Mappers
{
    public class OrderMapper : IMapper<OrderEntity, IOrder>
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
    }
}
