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
        public DeliveryTypeEntity FromDomainToEntity(DeliveryType delTypeFromDomain) {

            return new DeliveryTypeEntity { ID = delTypeFromDomain.ID, DeliveryType = delTypeFromDomain.Type };
        
        
        }

        public DeliveryType FromEntityToDomain(DeliveryTypeEntity delTypeFromDB) {

            return new DeliveryType { ID = delTypeFromDB.ID, Type = delTypeFromDB.DeliveryType };
        
        }
    }
}
