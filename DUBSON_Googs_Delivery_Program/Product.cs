using System;
using System.Collections.Generic;
using System.Text;

namespace DUBSON_Goods_Delivery_Program
{
    public class Product : ProductInterface
    {
        private string _name;

        public string Name {

            get => _name;
            set => _name = value;
        
        }
        
        // поле, що визначає ціну на товар
        
        private double _price;

        public double Price {

            get => _price;

        }

        // поле, що визначає масу товару
        private double _weight;

        public double Weight {

            get => _weight;

        }

        // поле, що визначає об'єм товару
        private double _volume;
        
        public double Volume {

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
        public Product (string name, double price, double weight, bool isFragile){

            _name = name;
            
            if (370 < weight & weight < 2000) {

                _type = ProductSizeType.Medium;

            }
            else if ( 0 < weight & weight<370 ) {

                _type = ProductSizeType.Little;
            
            }
            else if (weight<=0) {

                _type = ProductSizeType.Little;
            }
            else if (weight>=2000) {
                
                _type = ProductSizeType.Huge;
            
            }
            
            _weight = weight;
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
