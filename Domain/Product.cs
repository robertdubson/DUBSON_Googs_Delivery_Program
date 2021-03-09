using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }
        public double Price { get; set; }
        public double TimeForPreparation { get; set; }
        public int ID { get; set; }
        public DeliveryType Type { get; set; }

        public Product(int ID, string name, double weight, double volume, double price, double timeForPreparation, DeliveryType type) {

            this.ID = ID;
            Name = name;
            Weight = weight;
            Volume = volume;
            Price = price;
            TimeForPreparation = timeForPreparation;
            Type = type;
        
        }

        public Product() { 
        
        
        
        }

    }
}
