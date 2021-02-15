using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class OrderEntity : BaseEntity
    {
        private int _destinationID;

        public int DestinationID { get => _destinationID; set => _destinationID = value; }

        private int _productID;

        public int ProductID { get => _productID; set => _productID = value; }

        private DateTime _time_Of_Ordering;

        public DateTime Time_Of_Ordering { get => _time_Of_Ordering; set => _time_Of_Ordering = value; }

        private double _time_For_Delivery;

        public double TimeNeededForDelivery { get => _time_For_Delivery; set => _time_For_Delivery = value; }
    }
}
