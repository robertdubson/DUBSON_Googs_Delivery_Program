using System;
using System.Collections.Generic;
using System.Text;

namespace DUBSON_Goods_Delivery_Program
{
    public class Product
    {
        // поле, що визначає ціну на товар
        private long _price;

        public long Price {

            get => _price;

        }

        // поле, що визначає масу товару
        private long _weight;

        public long Weight {

            get => _weight;

        }

        // поле, що визначає об'єм товару
        private long _volume;
        
        public long Volume {

            get => _volume;
        }

        // поле, що визначає, чи є товар хрупким
        private bool _isFragile;

        public bool IsFragile {
            get => _isFragile;
        
        }

        private ProductType _type;

        public ProductType Type {

            get => _type;

        }

        // конструктор
        public Product (long price, long weight, bool isFragile){

            if (370 < weight & weight < 200) {

                _type = ProductType.Medium;

            }
            else if ( 0< weight & weight<370 ) {

                _type = ProductType.Little;
            
            }
            else if (weight<=0) {

                _type = ProductType.Little;
            }
            else if (weight>=370) {
                _type = ProductType.Huge;
            
            }

            _price = price;
            _isFragile = isFragile;

        }




    }
    public enum ProductType { 
        
        Huge,
        Little,
        Medium
    
    }
}
