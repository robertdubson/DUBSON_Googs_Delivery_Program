using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
namespace Services.Strategy
{
    public interface IStrategy
    {
        Order CreateAnOrder(Destination destination, Product product, List<Transport> suitableTransport, Func<Transport, Order> getOrderByTransport);
    }
}
