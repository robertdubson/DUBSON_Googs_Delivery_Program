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
        public Order CreateAnOrder(Destination destination, Product product, List<Transport> suitableTransport, Func<Transport, Order> getOrderByTransport)
        {
            List<Transport> currentTransports = suitableTransport;

            List<DateTime> timesOfDelivery = new List<DateTime>();

            Dictionary<DateTime, Transport> dateTransportDictionary = new Dictionary<DateTime, Transport>();

            Transport selectedTransport = suitableTransport.FindAll(transport => transport.InTheShop).ToList().ElementAt(0);

            double timeNeededForDelivery = 0;

            double dist = destination.Distance;

            double speed = selectedTransport.Speed;

            timeNeededForDelivery = dist / speed;

            //timeNeededForDelivery =  Convert.ToDouble(destination.Distance)  / Convert.ToDouble(selectedTransport.Speed);

            timeNeededForDelivery = product.TimeForPreparation + timeNeededForDelivery;

            //selectedTransport.InTheShop = false;

            Order newOrder = new Order(destination, selectedTransport, product, DateTime.Now, timeNeededForDelivery);

            return newOrder;
        }
    }
}
