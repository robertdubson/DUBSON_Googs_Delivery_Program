using System;
using System.Collections.Generic;
using System.Text;

namespace DUBSON_Goods_Delivery_Program
{
    public interface DataKeeperInterface
    {
        public List<Destination> AvailableDestinations { get; set; }

        public List<Product> AvailableProducts { get; set; }
        
        public List<Transport> AvailableTransport { get; set; }
    }
}
