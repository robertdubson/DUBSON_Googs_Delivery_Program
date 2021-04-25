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
        IOrder CreateAnOrder(IDestination destination, IProduct product, List<ITransport> suitableTransport, Func<ITransport, IOrder> getOrderByTransport);
    }
}
