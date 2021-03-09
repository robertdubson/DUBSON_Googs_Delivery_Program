using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IOrder
    {
        int ID { get; set; }
        
        IDestination Destination { get; set; }

        ITransport InvolvedTransport { get; set; }

        IProduct Product{ get; set; }

        DateTime TimeOfOrdering { get; set; }

        double TimeNeededForDelivery { get; set; }


    }
}
