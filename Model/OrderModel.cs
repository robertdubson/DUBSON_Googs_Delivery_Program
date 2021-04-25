using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderModel
    {
        public int ID { get; set; }

        public DestinationModel Destination { get; set; }

        public TransportModel InvolvedTransport { get; set; }

        public ProductModel Product { get; set; }

        public DateTime TimeOfOrdering { get; set; }

        public double TimeNeededForDelivery { get; set; }

        public override string ToString()
        {
            return Destination.Name +  " " + Product.Name + " " + Product.Price + " " + TimeOfOrdering.ToString();
        }
    }
}
