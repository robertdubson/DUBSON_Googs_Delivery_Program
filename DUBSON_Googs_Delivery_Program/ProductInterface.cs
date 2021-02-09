using System;
using System.Collections.Generic;
using System.Text;

namespace DUBSON_Goods_Delivery_Program
{
    public interface ProductInterface
    {
        public long Price { get; }
        
        public long Weight { get; }

        public long Volume { get; }

        public bool IsFragile { get; }

    }
}
