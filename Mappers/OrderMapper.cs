using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Domain;

namespace Mappers
{
    public class OrderMapper
    {
        DestinationMapper destMapper = new DestinationMapper();

        ProductMapper prodMapper = new ProductMapper();

        //TransportMapper transportMapper = new TransportMapper();

        public OrderEntity FromDomainToEntity(IOrder orderFromDomain)
        {

            return new OrderEntity
            {
                ID = orderFromDomain.ID,

                Product = prodMapper.FromDomainToEntity(orderFromDomain.Product),

                Destination = destMapper.FromDomainToEntity(orderFromDomain.Destination),

                Time_Of_Ordering = orderFromDomain.TimeOfOrdering,

                TimeNeededForDelivery = orderFromDomain.TimeNeededForDelivery


            };

        }

        public IOrder FromEntityToDomain(OrderEntity orderFromDB)
        {

            return new Order()
            {
                ID = orderFromDB.ID,

                Product = prodMapper.FromEntityToDomain(orderFromDB.Product),

                Destination = destMapper.FromEmtityToDomain(orderFromDB.Destination),

                TimeOfOrdering = orderFromDB.Time_Of_Ordering,

                TimeNeededForDelivery = orderFromDB.TimeNeededForDelivery


            };

        }
    }
}
