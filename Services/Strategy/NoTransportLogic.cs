using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Strategy
{
    public class NoTransportLogic : IStrategy
    {
        public Order ProcessTheOrder(Destination destination, Product product, List<Transport> suitableTransport, Func<Transport, Order> getOrderByTransport)
        {
            List<Transport> currentTransports = suitableTransport;

            List<DateTime> timesOfDelivery = new List<DateTime>();


            Dictionary<DateTime, Transport> dateTransportDictionary = new Dictionary<DateTime, Transport>();

            currentTransports.ForEach(transport => dateTransportDictionary.Add(getOrderByTransport(transport).TimeOfOrdering.AddSeconds(getOrderByTransport(transport).TimeNeededForDelivery), transport));

            List<DateTime> keysList = dateTransportDictionary.Keys.ToList();

            keysList.Sort((date1, date2) => date1.CompareTo(date2));

            DateTime theLeastTime = keysList.ElementAt(0);

            double timeNeededForDelivry = theLeastTime.Subtract(DateTime.Now).TotalSeconds + destination.Distance / dateTransportDictionary[theLeastTime].Speed + product.TimeForPreparation + getOrderByTransport(dateTransportDictionary[theLeastTime]).Destination.Distance / dateTransportDictionary[theLeastTime].Speed;

            Order newOrder = new Order(destination, dateTransportDictionary[theLeastTime], product, DateTime.Now, timeNeededForDelivry);

            return newOrder;
        }
    }
}
