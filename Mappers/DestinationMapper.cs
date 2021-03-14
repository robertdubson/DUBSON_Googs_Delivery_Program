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
    public class DestinationMapper : IMapper<DestinationEntity, IDestination, DestinationModel>
    {
        

        public DestinationEntity FromDomainToEntity(IDestination domainObject) {

            return new DestinationEntity() { DistanceFromCenter = domainObject.Distance, Name = domainObject.Name, ID = domainObject.ID };
        
        }

        public DestinationModel FromDomainToModel(IDestination domainObject)
        {
            return new DestinationModel { ID = domainObject.ID, Distance = domainObject.Distance, Name = domainObject.Name };
        }

        public IDestination FromEntityToDomain(DestinationEntity entityObject)
        {
            return new Destination { Distance = entityObject.DistanceFromCenter, Name = entityObject.Name, ID = entityObject.ID };
        }

        public IDestination FromModelToDomain(DestinationModel modelObject)
        {
            return new Destination { Distance = modelObject.Distance, ID = modelObject.ID, Name = modelObject.Name };
        }
    }
}
