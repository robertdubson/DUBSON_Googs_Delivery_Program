using System;
using System.Collections.Generic;
using System.Text;

namespace DUBSON_Goods_Delivery_Program
{
    public interface DeliveryManagerInterface
    {
        public List<Transport> BusyTransport { get;  }

        public DataKeeper CurrentDataKeeper { get; }

        public List<Order> ProcessedOrders { get; }
    }
}
