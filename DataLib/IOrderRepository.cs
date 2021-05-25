﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DataLib
{
    public interface IOrderRepository : IRepository<OrderEntity, int>
    {
        OrderEntity GetByInvolvedTransport(TransportEntity transport);

        
    }
}
