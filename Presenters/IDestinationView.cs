using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Presenters
{
    public interface IDestinationView
    {
        ProductModel SelectedProduct { get; set; }

        DestinationModel SelectedDestination { get; set; }

        void DisplayData(List<DestinationModel> destinations);

        void DisplayCurrentOrderInfo(OrderModel order);

        void DestinationWasntSelected();

        event Action DestinationSelected;
    }
}
