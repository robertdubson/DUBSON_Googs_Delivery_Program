using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Entity
{
    
    public class DeliveryTypeEntity : BaseEntity
    {
        

        public string DeliveryType { get; set; }

        public override string ToString()
        {
            return DeliveryType;
        }

    }
}
