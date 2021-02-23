﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ProductEntity : BaseEntity
    {
        public string Name { get; set; }

        public double Weight { get; set; }

        public double Volume { get; set; }

        public double Price { get; set; }

        public double TimeForPreparation { get; set; }

        public ProductEntity(string name, double weight, double volume, double price) {

            
            Name = name;

            Weight = weight;

            Volume = volume;

            Price = price;
        
        
        }


        public ProductEntity() { 
        
        
        
        }
    }
}
