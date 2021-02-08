using System;
using System.Collections.Generic;
using System.Text;

namespace DUBSON_Goods_Delivery_Program
{
    public class Transport
    {
        // поле, що визначає швидкість виду транспорту field
        private long _speed;


        public long Speed {

            get => _speed;
        }
        
        // поле, що визначає, чи в дорозі зараз транспортний засіб
        private bool _isCurrentlyBusy;

        public bool isCurrentlyBusy {

            get => _isCurrentlyBusy;
            set => _isCurrentlyBusy = value;
        
        }

        // конструктор
        public Transport(Transport_Category category) {

            // в залежності від категорії транспорту визначаємо швидкість, з якою засіб буде рухатись між містами

            if (category == Transport_Category.Car) {
                this._speed = 70;

            }
            else if (category == Transport_Category.Truck) {
                this._speed = 60;

            }
            else if (category == Transport_Category.Giant_Truck) {

                this._speed = 50;
            
            }
            
            this._isCurrentlyBusy = false;
        }



    }
    // перераховуємо можливі види транспорту
        public enum Transport_Category { 
        Truck,
        Giant_Truck,
        Car,

    }
}
