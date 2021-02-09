using System;
using System.Collections.Generic;
using System.Text;

namespace DUBSON_Goods_Delivery_Program
{
    public interface DataScannerInterface
    {
        public DataKeeper CurrentDataKeeper {

            get;
        
        }

        public Product SelectedProduct {
            
            get;
            set;
        
        }

        public Destination SelectedDestination {

            get;
            
            set;
        
        }
    }
}
