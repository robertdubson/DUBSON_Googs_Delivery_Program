using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Order : IOrder
    {
        public int ID { get; set; }
        
        public IDestination Destination { get; set; }
        
        public IProduct Product { get; set; }
        
        public DateTime TimeOfOrdering { get; set; }
        
        public double TimeNeededForDelivery { get; set; }

    }
}
