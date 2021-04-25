using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IDeliveryType
    {
        int ID { get;  }
        string Type { get; set; }
    }
}
