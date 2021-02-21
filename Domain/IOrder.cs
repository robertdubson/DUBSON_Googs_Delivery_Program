using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IOrder
    {
        IDestination Destination { get; set; }

        IProduct Product{ get; set; }

        DateTime TimeOfOrdering { get; set; }

        double TimeNeededForDelivery { get; set; }


    }
}
