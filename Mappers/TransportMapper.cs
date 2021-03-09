using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Domain;

namespace Mappers
{
    public class TransportMapper
    {
        DeliveryTypeMapper deliveryTypeMapper;
        
        public TransportMapper() {

            deliveryTypeMapper = new DeliveryTypeMapper();
        
        }

        public ITransport FromEntityToDomain(TransportEntity transportFromDB) {

            return new Transport
            {
                ID = transportFromDB.ID,
                Speed = transportFromDB.Speed,
                Type = deliveryTypeMapper.FromEntityToDomain(transportFromDB.DeliveryType)

            };
        
  
        }

        public TransportEntity FromDomainToEntity(ITransport transportFromDomain) {


            return new TransportEntity 
            { 
                
                Speed = transportFromDomain.Speed,
                ID = transportFromDomain.ID,
                DeliveryType = deliveryTypeMapper.FromDomainToEntity(transportFromDomain.Type) 
                                       
            
            };

        }

        
    }
}
