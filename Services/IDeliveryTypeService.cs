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
        List<IDeliveryType> GetAllDeliveryTypes();

        void UpdateDeliveryType(IDeliveryType deliveryType);

        void DeleteDeliveryType(IDeliveryType deliveryType);

        void AddDeliveryType(IDeliveryType deliveryType);
    }
}
