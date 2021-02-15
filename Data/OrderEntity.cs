using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class OrderEntity : BaseEntity
    {
        public int DestinationID { get; set; }

        public int ProductID { get; set; }

        public DateTime Time_Of_Ordering { get; set; }

        public double TimeNeededForDelivery { get; set; }

    }
}
