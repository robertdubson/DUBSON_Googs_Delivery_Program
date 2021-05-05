﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Entity;
using Mappers;
using DataLib;

namespace Services
{
    public interface IOrderService
    {
        void AddOrder(Order order);

        Order GetOrderByID(int ID);

        void DeleteOrder(int ID);

        


    }
}
