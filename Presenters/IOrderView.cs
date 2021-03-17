using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Presenters
{
    public interface IOrderView
    {
        event Action OrderCanceled;
        
        void DisplayData(List<OrderModel> orders);

        OrderModel SelectedOrder { get; }

        void OrderWasntselected();
    }
}
