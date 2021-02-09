using System;
using System.Collections.Generic;
using System.Text;

namespace DUBSON_Goods_Delivery_Program
{
    public class Order : OrderInterface
    {
        private Product _ordered_product;

        public Product Product {

            get => _ordered_product;

        }

        private Transport _used_transport;

        public Transport UsedTransport {

            get => _used_transport;

        }

        private DateTime _order_time;

        public DateTime OrderTime {

            get => _order_time;

        }

        private Destination _order_destination;

        public Destination OrderDestination {

            get => _order_destination;

        }

        private DateTime _delivery_time;

        public DateTime Delivery_Time {

            get => _delivery_time;
            set => _delivery_time = value;
        
        }

        /*public void setDeliveryTime(Transport free_transport, DateTime order_time, Destination selected_destination) {

            long added_hours = selected_destination.Distance / free_transport.Speed;

            //_delivery_time = order_time.AddHours(added_hours);

            // щоб нормально тестувати програму, будемо додавати секунди замість годин
            
            _delivery_time = order_time.AddSeconds(added_hours);

        }*/

        public Order(Product selected_product, Transport free_transport, DateTime order_time, Destination selected_destination) {

            _ordered_product = selected_product;

            _used_transport = free_transport;

            _order_time = order_time;

            _order_destination = selected_destination;

            //setDeliveryTime(free_transport, order_time, selected_destination);
        
        }


    }
}
