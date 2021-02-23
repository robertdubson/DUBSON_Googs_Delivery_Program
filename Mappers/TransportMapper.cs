using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Domain;

namespace Mappers
{
    public class TransportMapper
    {
        public ITransport FromEntityToDomain(TransportEntity transportFromDB) {

            if (transportFromDB.TransportType == TransportType.Truck) 
            {

                return new Truck() { Speed = transportFromDB.Speed };

            }
            else if (transportFromDB.TransportType == TransportType.Car) 
            {

                return new Car() { Speed = transportFromDB.Speed };

            }
            else
            {

                return new ProtectedVehicle { Speed = transportFromDB.Speed };
            
            }
        
  
        }

        public TransportEntity FromDomainToEntity(ITransport transportFromDomain) {


            return new TransportEntity { Speed = transportFromDomain.Speed,
                                         TransportType = TransportType.Car
                                       };

        }

        public TransportEntity FromDomainToEntity(Truck transportFromDomain) {

            return new TransportEntity
            {
                ID = transportFromDomain.ID,
                Speed = transportFromDomain.Speed,
                TransportType = TransportType.Truck
            };

        }

        public TransportEntity FromDomainToEntity(ProtectedVehicle transportFromDomain)
        {

            return new TransportEntity
            {
                ID = transportFromDomain.ID,
                Speed = transportFromDomain.Speed,
                TransportType = TransportType.ProtectedVehicle
            };

        }
    }
}
