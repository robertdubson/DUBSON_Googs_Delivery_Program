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

        public ITransport InvolvedTransport { get; set; }
        
        public IProduct Product { get; set; }
        
        public DateTime TimeOfOrdering { get; set; }
        
        public double TimeNeededForDelivery { get; set; }

        public Order(IDestination destination, ITransport transport, IProduct product, DateTime time, double timeNeededForDelivery) {

            

            Destination = destination;

            Product = product;

            InvolvedTransport = transport;

            TimeOfOrdering = time;

            TimeNeededForDelivery = timeNeededForDelivery;
        
        
        }

        public Order() { 
        
        
        
        }

    }
}
