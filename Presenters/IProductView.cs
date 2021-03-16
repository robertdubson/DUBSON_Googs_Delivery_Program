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

        DeliveryTypeModel SelectedType { get; set; }

        ProductModel SelectedProduct { get; set; }

        void DisplayData(List<DeliveryTypeModel> deliveryTypeItems, List<ProductModel> productItems); 

        

        void ProdSel();

        void CatSel();


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
