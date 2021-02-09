using System;
using System.Collections.Generic;
using System.Text;

namespace DUBSON_Goods_Delivery_Program
{
    public class DataScanner : DataScannerInterface
    {
        private DataKeeper _current_data_keeper;

        public DataKeeper CurrentDataKeeper { 
            
            get => _current_data_keeper; 
        
        }
        
        public DataScanner(DataKeeper dataKeeper) {

            _current_data_keeper = dataKeeper;
        
        }

        private Product _selected_product;

        public Product SelectedProduct {

            get => _selected_product;
            set => _selected_product = value;
        
        }

        private Destination _selected_destination;
        
        public Destination SelectedDestination {

            get => _selected_destination;
            set => _selected_destination = value;
        
        }

        public void ReadTheDataFromUser() {

            Dictionary<int, Product> product_dictionary = new Dictionary<int, Product>();
            
            int counter = 1;

            foreach (Product product in _current_data_keeper.AvailableProducts) {

                Console.WriteLine("ЛАСКАВО ПРОСИМО ДО МАГАЗИНУ!");
                
                Console.WriteLine(counter + " "+  product.Name + " ##### " + product.Price + "$ #####" + product.Weight + "kg ##### " + product.Volume + "m^3 #####");
                
                product_dictionary.Add(counter, product);
                
                counter++;
            
            }
            Console.WriteLine("Будь ласка, введіть номер товару, який ви хочете придбати");

            //string input_string = Console.ReadLine();
            int selected_number = Convert.ToInt32(Console.ReadLine());
            
            Product selected_product = product_dictionary[selected_number];
            
            _selected_product = selected_product;
            
            Dictionary<int, Destination> destination_dictionary = new Dictionary<int, Destination>();
            counter = 1;
            
            foreach (Destination dest in _current_data_keeper.AvailableDestinations) {

                Console.WriteLine(counter + " " + dest.Name + " " + dest.Distance + "km");
                
                destination_dictionary.Add(counter, dest);
                
                counter++;
            
            }

            Console.WriteLine("Введіть будь ласка номер пункту призначення, куди потрібно доставити товар.");

            selected_number = Convert.ToInt32(Console.ReadLine());

            Destination selected_destination = destination_dictionary[selected_number];

            _selected_destination = selected_destination;


        }

    }
}
