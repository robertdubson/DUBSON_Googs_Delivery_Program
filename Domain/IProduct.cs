using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IProduct
    {
        int ID { get; set; }
        string Name { get; set; }
        
        double Weight { get; set; }

        double Volume { get; set; }

        double Price { get; set; }

        double TimeForPreparation { get; set; }

        DeliveryType Type { get; set; }



    }
}
