using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Entity;
namespace Mappers
{
    public class DeliveryTypeMapper
    {
        public DeliveryTypeEntity FromDomainToEntity(DeliveryType domainObject) {

            return new DeliveryTypeEntity { ID = domainObject.ID, DeliveryType = domainObject.Type };
        
        
        }

        public DeliveryType FromEntityToDomain(DeliveryTypeEntity entityObject) {

            return new DeliveryType { ID = entityObject.ID, Type = entityObject.DeliveryType };
        
        }
    }
}
