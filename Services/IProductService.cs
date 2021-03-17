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
        void AddProduct(IProduct product);

        IProduct GetProductByID(int ID);

        void DeleteProduct(int ID);

        void UpdateProduct(IProduct product);

        List<IProduct> GetAllProducts();

        List<DeliveryType> GetAllTypes();

        List<IProduct> FindByText(string text);

        List<IProduct> FindByParameters(double maxWeight, double minWeight, double minVolume, double maxVolume, double maxPrice, double minPrice);

    }
}
