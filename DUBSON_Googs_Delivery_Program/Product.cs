using System;
using System.Collections.Generic;
using System.Text;

namespace DUBSON_Goods_Delivery_Program
{
    public class Product : ProductInterface
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

        private ProductSizeType _type;

        public ProductSizeType Type {

            get => _type;

        }

        // конструктор
        public Product (long price, long weight, bool isFragile){

            if (370 < weight & weight < 2000) {

                _type = ProductSizeType.Medium;

            }
            else if ( 0< weight & weight<370 ) {

                _type = ProductSizeType.Little;
            
            }
            else if (weight<=0) {

                _type = ProductSizeType.Little;
            }
            else if (weight>=2000) {
                
                _type = ProductSizeType.Huge;
            
            }

            _price = price;
            _isFragile = isFragile;

        }




    }
    public enum ProductSizeType { 
        
        Huge,
        Little,
        Medium
    
    }
}
