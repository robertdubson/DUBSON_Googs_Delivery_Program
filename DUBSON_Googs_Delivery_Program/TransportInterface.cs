using System;
using System.Collections.Generic;
using System.Text;

namespace DUBSON_Goods_Delivery_Program
{
    public interface TransportInterface
    {
        public double Speed { get; }

        public bool isCurrentlyBusy { get; }

    }
}
