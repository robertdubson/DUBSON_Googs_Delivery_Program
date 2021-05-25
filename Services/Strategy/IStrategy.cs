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
        Order ProcessTheOrder(PreprocessedOrder order, Func<Transport, Order> getOrderByTransport);
    }
}
