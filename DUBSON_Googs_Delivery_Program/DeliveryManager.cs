using System;
using System.Collections.Generic;
using System.Text;

namespace DUBSON_Goods_Delivery_Program
{
    public class DeliveryManager : DeliveryManagerInterface
    {
        private DataKeeper _current_data_keeper;

        public DataKeeper CurrentDataKeeper {

            get => _current_data_keeper;

        }

        private List<Order> _processed_orders;

        public List<Order> ProcessedOrders {

            get => _processed_orders;
        
        }

        private List<Transport> _busy_transport;

        public List<Transport> BusyTransport {
            
            get => _busy_transport;
        
        }

        public void ProcessTheOrder(DateTime time_of_ordering, Product choosen_product, Destination selected_destination) {

            if (choosen_product.IsFragile)
            {
                Transport selected_transport = _current_data_keeper.AvailableTransport.Find(transport =>!_busy_transport.Contains(transport) && transport.Category == Transport_Category.HighlyProtectedDelivery);

                StartDelivery(time_of_ordering, choosen_product, selected_destination, selected_transport);
                

            }
            
            else{
                
                if (choosen_product.Type == ProductSizeType.Little) {

                    Transport selected_transport = _current_data_keeper.AvailableTransport.Find(transport => !_busy_transport.Contains(transport) && transport.Category == Transport_Category.Car);
                    StartDelivery(time_of_ordering, choosen_product, selected_destination, selected_transport);


                }
                else if (choosen_product.Type == ProductSizeType.Medium) {

                    Transport selected_transport = _current_data_keeper.AvailableTransport.Find(transport => !_busy_transport.Contains(transport) && transport.Category == Transport_Category.Truck);
                    StartDelivery(time_of_ordering, choosen_product, selected_destination, selected_transport);


                }
                else if (choosen_product.Type == ProductSizeType.Huge) {

                    Transport selected_transport = _current_data_keeper.AvailableTransport.Find(transport => !_busy_transport.Contains(transport) && transport.Category == Transport_Category.Giant_Truck);
                    StartDelivery(time_of_ordering, choosen_product, selected_destination, selected_transport);

                }

            
            
            }
        
        }

        public void StartDelivery(DateTime time_of_ordering, Product choosen_product, Destination selected_destination, Transport selected_transport) {

            if (selected_transport == null)
            {
                selected_transport = _busy_transport.Find(transport => transport.Category == Transport_Category.HighlyProtectedDelivery);

                Order busy_order = _processed_orders.Find(ord => ord.UsedTransport == selected_transport);

                Order current_order = new Order(choosen_product, selected_transport, time_of_ordering, selected_destination);



                long added_hours = 0;

                added_hours = current_order.OrderDestination.Distance / current_order.UsedTransport.Speed;

                current_order.Delivery_Time = current_order.OrderTime.AddMinutes(added_hours);

                current_order.Delivery_Time.AddSeconds(busy_order.Delivery_Time.Subtract(current_order.Delivery_Time).TotalSeconds);

                _processed_orders.Add(current_order);

                Console.WriteLine("Товар буде доставлено через " + current_order.Delivery_Time);

                while (current_order.Delivery_Time.Subtract(DateTime.Now).Seconds >= 0)
                {

                    Console.WriteLine("Товар доставляється");

                }

                Console.WriteLine("Товар доставлено!");

                _busy_transport.Remove(selected_transport);

                _processed_orders.Remove(current_order);

            }
            else
            {

                Order current_order = new Order(choosen_product, selected_transport, time_of_ordering, selected_destination);

                long added_hours = 0;

                added_hours = current_order.OrderDestination.Distance / current_order.UsedTransport.Speed;

                current_order.Delivery_Time = current_order.OrderTime.AddMinutes(added_hours);

                _processed_orders.Add(current_order);

                _busy_transport.Add(selected_transport);

                Console.WriteLine("Товар буде доставлено " + current_order.Delivery_Time );
                
                
                while (current_order.Delivery_Time.Subtract(DateTime.Now).Seconds >= 0)
                {

                    Console.WriteLine("Товар доставляється");

                }
                
                Console.WriteLine("Товар доставлено!");

                _busy_transport.Remove(selected_transport);

                _processed_orders.Remove(current_order);

            }


        }

        public DeliveryManager(DataKeeper dataKeeper) {

            _current_data_keeper = dataKeeper;

            _processed_orders = new List<Order>();

            _busy_transport = new List<Transport>();
        
        }
    }
}
