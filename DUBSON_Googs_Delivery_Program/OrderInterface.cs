using System;
using System.Collections.Generic;
using System.Text;

namespace DUBSON_Goods_Delivery_Program
{
    public interface OrderInterface
    {
        

        public Product Product
        {

            get;

        }

        

        public Transport UsedTransport
        {

            get;

        }

        

        public DateTime OrderTime
        {

            get;

        }

        

        public Destination OrderDestination
        {

            get;

        }

        

        public DateTime Delivery_Time
        {
            get;
            set;

        }
    }
}
