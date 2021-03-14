using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProductModel
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }
        public double Price { get; set; }
        public double TimeForPreparation { get; set; }
        public int ID { get; set; }
        public  DeliveryTypeModel DeliveryType { get; set; }
    }
}
