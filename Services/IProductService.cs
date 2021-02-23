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
    }
}
