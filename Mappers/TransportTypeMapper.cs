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
    public class TransportTypeMapper : IMapper<TransportTypeEntity, ITransportType, TransportTypeModel>
    {
        public TransportTypeEntity FromDomainToEntity(ITransportType domainObject)
        {
            return new TransportTypeEntity() { ID = domainObject.ID, Type = domainObject.Type };
        }

        public TransportTypeModel FromDomainToModel(ITransportType domainObject)
        {
            return new TransportTypeModel() { ID = domainObject.ID, TransportType = domainObject.Type };
        }

        public ITransportType FromEntityToDomain(TransportTypeEntity entityObject)
        {
            return new TransportType() { ID = entityObject.ID, Type = entityObject.Type };
        }

        public ITransportType FromModelToDomain(TransportTypeModel modelObject)
        {
            return new TransportType() { ID = modelObject.ID, Type = modelObject.TransportType };
        }
    }
}
