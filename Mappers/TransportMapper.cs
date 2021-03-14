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
    public class TransportMapper : IMapper<TransportEntity, ITransport, TransportModel>
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

        public TransportModel FromDomainToModel(ITransport domainObject)
        {
            return new TransportModel { ID = domainObject.ID, DeliveryType = deliveryTypeMapper.FromDomainToModel(domainObject.Type), InTheShop = domainObject.InTheShop, Speed = domainObject.Speed };
        }

        public ITransport FromModelToDomain(TransportModel modelObject)
        {
            return new Transport { ID = modelObject.ID, Type = deliveryTypeMapper.FromModelToDomain(modelObject.DeliveryType), InTheShop = modelObject.InTheShop, Speed = modelObject.Speed };
        }
    }
}
