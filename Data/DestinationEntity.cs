using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DestinationEntity : BaseEntity
    {
        public string Name { get; set; }

        public double DistanceFromCenter { get; set; }


        public DestinationEntity(string name, double distance) {

            Name = name;

            DistanceFromCenter = distance;
        
        }
        
        
        public DestinationEntity(){
        
        }

    }
}
