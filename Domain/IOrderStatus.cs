using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IOrderStatus
    {
        int ID { get; set; }

        string Status { get; set; }
    }
}
