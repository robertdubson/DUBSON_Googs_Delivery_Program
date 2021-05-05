using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
namespace Services
{
    public interface IDeliveryTypeService
    {
        List<DeliveryType> GetAllDeliveryTypes();

        void UpdateDeliveryType(DeliveryType deliveryType);

        void DeleteDeliveryType(DeliveryType deliveryType);

        void AddDeliveryType(DeliveryType deliveryType);
    }
}
