using System;
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
        void AddOrder(IOrder order);

        IOrder GetOrderByID(int ID);

        void DeleteOrder(int ID);

        


    }
}
