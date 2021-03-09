﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TransportEntity : BaseEntity
    {
        public double Speed { get; set; }

        public DeliveryTypeEntity DeliveryType { get; set;  }


        public TransportEntity(double speed, DeliveryTypeEntity type) {

            Speed = speed;

            DeliveryType = type;
        
        }

        public TransportEntity() { 
        
        
        
        }


    }

    
}
