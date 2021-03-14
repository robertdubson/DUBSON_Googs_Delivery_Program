using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Domain;

namespace Mappers
{
    public class TransportMapper : IMapper<TransportEntity, ITransport>
    {
        DeliveryTypeMapper deliveryTypeMapper;
        
        public TransportMapper() {

            deliveryTypeMapper = new DeliveryTypeMapper();
        
        }

        public ITransport FromEntityToDomain(TransportEntity entityObject) {

            return new Transport
            {
                ID = entityObject.ID,
                Speed = entityObject.Speed,
                Type = deliveryTypeMapper.FromEntityToDomain(entityObject.DeliveryType)

            };
        
  
        }

        public TransportEntity FromDomainToEntity(ITransport domainObject) {


            return new TransportEntity 
            { 
                
                Speed = domainObject.Speed,
                ID = domainObject.ID,
                DeliveryType = deliveryTypeMapper.FromDomainToEntity(domainObject.Type) 
                                       
            
            };

        }

        
    }
}
