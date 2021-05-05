using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Transport 
    {
        public double Speed { get; set; }
        public int ID { get; set; }
        public DeliveryType Type { get; set; }

        public TransportType TransportType { get; set; }

        public bool InTheShop { get; set; }
    }
}
