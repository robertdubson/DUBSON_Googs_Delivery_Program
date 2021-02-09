using System;

namespace DUBSON_Goods_Delivery_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Product product_1 = new Product("Fridge", 3500, 200, false);
            Product product_2 = new Product("Table", 3000, 100, false);
            Product product_3 = new Product("Tablet PC", 5000, 1, true);
            
            DataKeeper my_data_keeper = new DataKeeper();
            
            my_data_keeper.AvailableProducts.Add(product_1);
            my_data_keeper.AvailableProducts.Add(product_2);
            my_data_keeper.AvailableProducts.Add(product_3);
            my_data_keeper.AvailableProducts.Add(new Product("Camera", 4400, 2, true));
            my_data_keeper.AvailableProducts.Add(new Product("Chair", 3675, 10, false));
            my_data_keeper.AvailableProducts.Add(new Product("DVD Player", 5000, 4, false));

            my_data_keeper.AvailableDestinations.Add(new Destination(10, "Paris"));
            my_data_keeper.AvailableDestinations.Add(new Destination(8, "Київ"));
            my_data_keeper.AvailableDestinations.Add(new Destination(12, "Житомир"));
            my_data_keeper.AvailableDestinations.Add(new Destination(15, "Одеса"));
            my_data_keeper.AvailableDestinations.Add(new Destination(10, "Жовтi Води"));

            my_data_keeper.AvailableTransport.Add(new Transport(Transport_Category.Car));
            my_data_keeper.AvailableTransport.Add(new Transport(Transport_Category.Car));
            my_data_keeper.AvailableTransport.Add(new Transport(Transport_Category.Giant_Truck));
            my_data_keeper.AvailableTransport.Add(new Transport(Transport_Category.HighlyProtectedDelivery));
            my_data_keeper.AvailableTransport.Add(new Transport(Transport_Category.Truck));
            my_data_keeper.AvailableTransport.Add(new Transport(Transport_Category.Car));
            my_data_keeper.AvailableTransport.Add(new Transport(Transport_Category.Truck));

            DataScanner scanner = new DataScanner(my_data_keeper);

            scanner.ReadTheDataFromUser();

            DeliveryManager my_delivery_manager = new DeliveryManager(my_data_keeper);

            my_delivery_manager.ProcessTheOrder(DateTime.Now, scanner.SelectedProduct, scanner.SelectedDestination);


        }
    }
}
