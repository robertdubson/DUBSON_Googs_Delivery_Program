using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Presenters
{
    public interface IProductView
    {
        event Action ProductSelected;

        event Action CategorySelected;

        event Action parametersChanged;

        event Action textChanged;

        string InsertedText { get; }

        decimal minWeight { get; }

        decimal maxWeight { get; }

        decimal minVolume { get; }

        decimal maxVolume { get; }

        decimal minPrice { get; }

        decimal maxPrice { get; }

        DeliveryTypeModel SelectedType { get; set; }

        ProductModel SelectedProduct { get; set; }

        void DisplayData(List<DeliveryTypeModel> deliveryTypeItems, List<ProductModel> productItems); 

        

        


    }

    public class DeliveryTypeEventArgs : EventArgs { 
    
        public DeliveryTypeModel DeliveryType { get; set; }

        public DeliveryTypeEventArgs(DeliveryTypeModel deliveryType) {

            DeliveryType = deliveryType;
        
        }
    
    }

    public class ProductEventArgs : EventArgs {

        public ProductModel Product { get; set; }

        public ProductEventArgs(ProductModel product) {

            Product = product;
        
        }

    
    }
}
