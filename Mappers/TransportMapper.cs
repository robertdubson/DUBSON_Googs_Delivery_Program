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
    public class TransportMapper : IMapper<TransportEntity, Transport, TransportModel>
    {
        DeliveryTypeMapper deliveryTypeMapper;

        TransportTypeMapper _transportTypeMapper;
        
        public TransportMapper() {

            deliveryTypeMapper = new DeliveryTypeMapper();

            _transportTypeMapper = new TransportTypeMapper();
        
        }

        public Transport FromEntityToDomain(TransportEntity entityObject) {

            return new Transport
            {
                ID = entityObject.ID,
                Speed = entityObject.Speed,
                Type = deliveryTypeMapper.FromEntityToDomain(entityObject.DeliveryType),
                InTheShop = entityObject.InTheShop,
                TransportType = _transportTypeMapper.FromEntityToDomain(entityObject.TransportType)
                

            };
        
  
        }

        public TransportEntity FromDomainToEntity(Transport domainObject) {


            return new TransportEntity
            {

                Speed = domainObject.Speed,
                ID = domainObject.ID,
                DeliveryType = deliveryTypeMapper.FromDomainToEntity(domainObject.Type),
                InTheShop = domainObject.InTheShop,
                TransportType = _transportTypeMapper.FromDomainToEntity(domainObject.TransportType)
                                       
            
            };

        }

        public TransportModel FromDomainToModel(Transport domainObject)
        {
            return new TransportModel { ID = domainObject.ID, DeliveryType = deliveryTypeMapper.FromDomainToModel(domainObject.Type), InTheShop = domainObject.InTheShop, Speed = domainObject.Speed, TransportType = _transportTypeMapper.FromDomainToModel(domainObject.TransportType) };
        }

        public Transport FromModelToDomain(TransportModel modelObject)
        {
            return new Transport { ID = modelObject.ID, Type = deliveryTypeMapper.FromModelToDomain(modelObject.DeliveryType), InTheShop = modelObject.InTheShop, Speed = modelObject.Speed, TransportType = _transportTypeMapper.FromModelToDomain(modelObject.TransportType) };
        }
    }
}
