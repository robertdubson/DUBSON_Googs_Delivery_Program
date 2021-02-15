using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DestinationEntity : BaseEntity
    {
        
        private string _name;
        
        public string Name { get => _name; set => _name = value; }

        private double _distance_From_Center;

        public double DistanceFromCenter { get => _distance_From_Center; set => _distance_From_Center = value; }
    
    }
}
