using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Entity;
using Model;
namespace Mappers
{
    public class DeliveryTypeMapper : IMapper<DeliveryTypeEntity, IDeliveryType, DeliveryTypeModel>
    {
        public DeliveryTypeEntity FromDomainToEntity(IDeliveryType domainObject) {

            return new DeliveryTypeEntity { ID = domainObject.ID, DeliveryType = domainObject.Type };
        
        
        }

        public DeliveryTypeModel FromDomainToModel(IDeliveryType domainObject)
        {
            return new DeliveryTypeModel { ID = domainObject.ID, DeliveryType = domainObject.Type };
        }

        public IDeliveryType FromEntityToDomain(DeliveryTypeEntity entityObject) {

            return new DeliveryType { ID = entityObject.ID, Type = entityObject.DeliveryType };
        
        }

        public IDeliveryType FromModelToDomain(DeliveryTypeModel modelObject)
        {
            return new DeliveryType { ID = modelObject.ID, Type = modelObject.DeliveryType };
        }
    }
}
