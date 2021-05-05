using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Entity;
using DataLib;
using Mappers;

namespace Services
{
    public interface IProductService
    {
        void AddProduct(Product product);

        Product GetProductByID(int ID);

        void DeleteProduct(int ID);

        

        List<Product> GetAllProducts();

        List<DeliveryType> GetAllTypes();

        List<Product> FindByText(string text);

        List<Product> FindByParameters(double maxWeight, double minWeight, double minVolume, double maxVolume, double maxPrice, double minPrice);

    }
}
