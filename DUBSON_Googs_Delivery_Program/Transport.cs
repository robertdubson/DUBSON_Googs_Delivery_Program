using System;
using System.Collections.Generic;
using System.Text;

namespace DUBSON_Goods_Delivery_Program
{
    public class Transport : TransportInterface
    {
        // поле, що визначає швидкість виду транспорту field
        private double _speed;


        public double Speed {

            get => _speed;
        
        }
        
        // поле, що визначає, чи в дорозі зараз транспортний засіб
        private bool _isCurrentlyBusy;

        public bool isCurrentlyBusy {

            get => _isCurrentlyBusy;
            set => _isCurrentlyBusy = value;
        
        }

        private Transport_Category _category;

        public Transport_Category Category {

            get => _category;

        }

        // конструктор
        public Transport(Transport_Category category) {

            // в залежності від категорії транспорту визначаємо швидкість, з якою засіб буде рухатись між містами

            _category = category;

            if (category == Transport_Category.Car)
            {
                this._speed = 70;

            }
            else if (category == Transport_Category.Truck)
            {
                this._speed = 60;

            }
            else if (category == Transport_Category.Giant_Truck)
            {

                this._speed = 50;

            }
            else if (category == Transport_Category.HighlyProtectedDelivery) {

                this._speed = 55;

            }
            
            this._isCurrentlyBusy = false;
        
        }



    }
    // перераховуємо можливі види транспорту
        public enum Transport_Category { 
        Truck,
        Giant_Truck,
        Car,
        HighlyProtectedDelivery
        }
}
