using System;
using System.Collections.Generic;
using System.Text;

namespace DUBSON_Goods_Delivery_Program
{
    public class DataScanner
    {
        private DataKeeper _current_data_keeper;

        public DataKeeper CurrentDataKeeper { 
            
            get => _current_data_keeper; 
        
        }
        
        public DataScanner(DataKeeper dataKeeper) {

            _current_data_keeper = dataKeeper;
        
        }

        public void ReadTheDataFromUser() {

            foreach (Product product in _current_data_keeper.AvailableProducts) { 
            
            
            }

        
        }

    }
}
