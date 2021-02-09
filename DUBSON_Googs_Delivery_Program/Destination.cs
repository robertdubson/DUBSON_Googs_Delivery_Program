using System;
using System.Collections.Generic;
using System.Text;

namespace DUBSON_Goods_Delivery_Program
{
    public class Destination : DestinationInterface
    {
        //поле, що визначає відстань від пункту призначення до головного магазина
        private long _distance;

        public long Distance {

            get => _distance;
        
        }

        //поле, що визначає назву населеного пункту
        private string _name;

        public string Name {

            get => _name;
        }

        // конструктор
        public Destination(long distance, string name) {

            _distance = distance;
            _name = name;
        
        }
    }
}
