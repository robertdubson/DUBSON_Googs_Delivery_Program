using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Order
    {
        public int ID { get; set; }
        
        public Destination Destination { get; set; }

        public Transport InvolvedTransport { get; set; }
        
        public Product Product { get; set; }
        
        public DateTime TimeOfOrdering { get; set; }
        
        public double TimeNeededForDelivery { get; set; }

        public OrderStatus Status { get; set; }

        public Order(Destination destination, Transport transport, Product product, DateTime time, double timeNeededForDelivery) {

            

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
