﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DeliveryTypeModel
    {
        public int ID { get; set; }

        public string DeliveryType { get; set; }

        public override string ToString() {

            return DeliveryType;

        }
    }
}
