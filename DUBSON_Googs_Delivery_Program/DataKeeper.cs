using System;
using System.Collections.Generic;
using System.Text;

namespace DUBSON_Goods_Delivery_Program
{
    public class DataKeeper
    {
        private List<Destination> _available_destinations;

        public List<Destination> AvailableDestinations{

            get => _available_destinations;
            set => _available_destinations = value;
    
        }

        private List<Product> _available_products;

        public List<Product> AvailableProducts {

            get => _available_products;
            set => _available_products = value; 
        
        }

        private List<Transport> _available_transport;

        public List<Transport> AvailableTransport {

            get => _available_transport;
            set => _available_transport = value;
        
        }

        public DataKeeper() {

            this._available_destinations = new List<Destination>();
            this._available_products = new List<Product>();
            this._available_transport = new List<Transport>();
        
        }
    }
}
