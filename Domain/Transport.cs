using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Transport : ITransport
    {
        public double Speed { get; set; }
        public int ID { get; set; }
        public IDeliveryType Type { get; set; }
        public bool InTheShop { get; set; }
    }
}
