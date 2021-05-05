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
    public class TransportTypeMapper : IMapper<TransportTypeEntity, TransportType, TransportTypeModel>
    {
        public TransportTypeEntity FromDomainToEntity(TransportType domainObject)
        {
            return new TransportTypeEntity() { ID = domainObject.ID, Type = domainObject.Type };
        }

        public TransportTypeModel FromDomainToModel(TransportType domainObject)
        {
            return new TransportTypeModel() { ID = domainObject.ID, TransportType = domainObject.Type };
        }

        public TransportType FromEntityToDomain(TransportTypeEntity entityObject)
        {
            return new TransportType() { ID = entityObject.ID, Type = entityObject.Type };
        }

        public TransportType FromModelToDomain(TransportTypeModel modelObject)
        {
            return new TransportType() { ID = modelObject.ID, Type = modelObject.TransportType };
        }
    }
}
