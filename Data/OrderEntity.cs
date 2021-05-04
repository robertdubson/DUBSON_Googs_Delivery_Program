using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class OrderEntity : BaseEntity
    {
        public DestinationEntity Destination { get; set; }

        public ProductEntity Product { get; set; }

        public TransportEntity InvolvedTransport { get; set; }

        public DateTime Time_Of_Ordering { get; set; }

        public double TimeNeededForDelivery { get; set; }

        public OrderStatusEntity OrderStatus { get; set; }

        public OrderEntity(DestinationEntity dest, ProductEntity prod, DateTime orderTime, double timeOfDelivery, TransportEntity involvedTransport) {

            Destination = dest;

            Product = prod;

            InvolvedTransport = involvedTransport;

            Time_Of_Ordering = orderTime;

            TimeNeededForDelivery = timeOfDelivery;
        
        }

        
        public OrderEntity() { }

    }
}
