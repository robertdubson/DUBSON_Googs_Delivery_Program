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

        public void ProcessTheOrder(DateTime time_of_ordering, Product choosen_product, Destination selected_destination);

        public void StartDelivery(DateTime time_of_ordering, Product choosen_product, Destination selected_destination, Transport selected_transport);
    }
}
