using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Domain;

namespace Mappers
{
    public class DestinationMapper
    {
        public IDestination FromEmtityToDomain(DestinationEntity entityFromDB) {

            return new Destination { Distance = entityFromDB.DistanceFromCenter, Name = entityFromDB.Name, ID = entityFromDB.ID };
        
        }

        public DestinationEntity FromDomainToEntity(IDestination destinationFromDomain) {

            return new DestinationEntity() { DistanceFromCenter = destinationFromDomain.Distance, Name = destinationFromDomain.Name, ID = destinationFromDomain.ID };
        
        }
    }
}
