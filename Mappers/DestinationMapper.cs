using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Domain;

namespace Mappers
{
    public class DestinationMapper : IMapper<DestinationEntity, IDestination>
    {
        

        public DestinationEntity FromDomainToEntity(IDestination domainObject) {

            return new DestinationEntity() { DistanceFromCenter = domainObject.Distance, Name = domainObject.Name, ID = domainObject.ID };
        
        }

        public IDestination FromEntityToDomain(DestinationEntity entityObject)
        {
            return new Destination { Distance = entityObject.DistanceFromCenter, Name = entityObject.Name, ID = entityObject.ID };
        }
    }
}
