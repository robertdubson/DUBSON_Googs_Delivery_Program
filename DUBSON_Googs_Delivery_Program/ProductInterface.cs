using System;
using System.Collections.Generic;
using System.Text;

namespace DUBSON_Goods_Delivery_Program
{
    public interface ProductInterface
    {
        
        public string Name { get; set; }
        public double Price { get; }
        
        public double Weight { get; }

        public double Volume { get; }

        public bool IsFragile { get; }

    }
}
