﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class OrderStatus : IOrderStatus
    {
        public int ID { get; set; }

        public string Status { get; set; }
    }
}
