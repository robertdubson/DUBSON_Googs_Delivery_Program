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

        public Product(string name, double weight, double volume, double price, double timeForPreparation) {

            Name = name;
            Weight = weight;
            Price = price;
            TimeForPreparation = timeForPreparation;
        
        }

    }
}
