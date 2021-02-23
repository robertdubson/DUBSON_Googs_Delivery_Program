using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TransportEntity : BaseEntity
    {
        public double Speed { get; set; }

        public TransportType TransportType { get; set; }


        public TransportEntity(double speed, TransportType type) {

            Speed = speed;

            TransportType = type;
        
        }

        public TransportEntity() { 
        
        
        
        }


    }

    public enum TransportType { 
    
        ProtectedVehicle,
        Car,
        Truck
    
    }
}
