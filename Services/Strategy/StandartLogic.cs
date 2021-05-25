using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Strategy
{
    public class StandartLogic : IStrategy
    {
        public Order ProcessTheOrder(PreprocessedOrder order, Func<Transport, Order> getOrderByTransport)
        {
            List<Transport> currentTransports = order.SuitableTransport;

            List<DateTime> timesOfDelivery = new List<DateTime>();

            Dictionary<DateTime, Transport> dateTransportDictionary = new Dictionary<DateTime, Transport>();

            Transport selectedTransport = order.SuitableTransport.FindAll(transport => transport.InTheShop).ToList().ElementAt(0);

            double timeNeededForDelivery = 0;

            double dist = order.Destination.Distance;

            double speed = selectedTransport.Speed;

            timeNeededForDelivery = dist / speed;

            //timeNeededForDelivery =  Convert.ToDouble(destination.Distance)  / Convert.ToDouble(selectedTransport.Speed);

            timeNeededForDelivery = order.Product.TimeForPreparation + timeNeededForDelivery;

            //selectedTransport.InTheShop = false;

            Order newOrder = new Order(order.Destination, selectedTransport, order.Product, DateTime.Now, timeNeededForDelivery);

            return newOrder;
        }
    }
}
