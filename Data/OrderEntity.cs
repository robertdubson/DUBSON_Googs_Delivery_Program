using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class OrderEntity : BaseEntity
    {
        public DestinationEntity Destination { get; set; }

        public ProductEntity Product { get; set; }

        public DateTime Time_Of_Ordering { get; set; }

        public double TimeNeededForDelivery { get; set; }

    }
}
