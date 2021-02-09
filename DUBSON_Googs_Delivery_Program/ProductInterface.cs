using System;
using System.Collections.Generic;
using System.Text;

namespace DUBSON_Goods_Delivery_Program
{
    public interface ProductInterface
    {
        
        public string Name { get; set; }
        public long Price { get; }
        
        public long Weight { get; }

        public long Volume { get; }

        public bool IsFragile { get; }

    }
}
