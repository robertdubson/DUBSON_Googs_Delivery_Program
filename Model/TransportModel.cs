using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TransportModel
    {
        public double Speed { get; set; }
        public int ID { get; set; }
        public DeliveryTypeModel DeliveryType { get; set; }
        public bool InTheShop { get; set; }

        public TransportTypeModel TransportType { get; set; }
    }
}
