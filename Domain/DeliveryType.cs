using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DeliveryType : IDeliveryType
    {
        public int ID { get; set; }

        public string Type { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as DeliveryType);
        }
        public bool Equals(DeliveryType deltype) {

            return (deltype.ID == this.ID) && (deltype.Type == this.Type);

        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
