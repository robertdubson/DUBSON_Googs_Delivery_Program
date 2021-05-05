using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataLib;
using Mappers;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        ProductMapper _productMapper;

        DeliveryTypeMapper _deliveryTypeMapper;

        public ProductService(IProductRepository repository) {

            _productRepository = repository;

            _productMapper = new ProductMapper();

            _deliveryTypeMapper = new DeliveryTypeMapper();
        
        }

        public void AddProduct(Product product)
        {
            _productRepository.Add(_productMapper.FromDomainToEntity(product));
        }

        public void DeleteProduct(int ID)
        {
            _productRepository.Delete(ID);
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAll().Select(prod => _productMapper.FromEntityToDomain(prod)).ToList();
        }

        public List<DeliveryType> GetAllTypes()
        {
            return _productRepository.GetAllTypes().Select(deliveryType => _deliveryTypeMapper.FromEntityToDomain(deliveryType)).ToList();
        }

        public Product GetProductByID(int ID)
        {
            return _productMapper.FromEntityToDomain(_productRepository.GetByID(ID));
        }

        

        public List<Product> GetProductsByType(DeliveryType delType) {

            return _productRepository.GetAll().ToList().FindAll(prod => prod.DeliveryType.ID == _deliveryTypeMapper.FromDomainToEntity(delType).ID).Select(prod => _productMapper.FromEntityToDomain(prod)).ToList();
        
        }

        public List<Product> FindByText(string text) {

            List<Product> suitableProducts = new List<Product>();

            if (text == "")
            {

                return this.GetAllProducts();


            }
            else {

                foreach (char ch in text)
                {

                    foreach (Product prod in this.GetAllProducts())
                    {

                        if (prod.ToString().Contains(ch))
                        {

                            suitableProducts.Add(prod);

                        }
                    }
                }

                return suitableProducts.Distinct().ToList();

            }            
        
        }

        public List<Product> FindByParameters(double maxWeight, double minWeight, double minVolume, double maxVolume, double maxPrice, double minPrice) {

            List<Product> resultList = new List<Product>();

            foreach (Product prod in this.GetAllProducts()) {

                if (prod.Price > minPrice) {

                    resultList.Add(prod);
                
                }
                if (prod.Volume > minVolume) {

                    resultList.Add(prod);
                
                }
                if (prod.Weight > minVolume) {

                    resultList.Add(prod);
                
                }          
            
            }     

            return resultList;
        
        }

        //public List<IProduct> FindByParameters(double maxWeight, double minWeight, double minVolume, double maxVolume, double maxPrice, double minPrice) {

            //return this.GetAllProducts().FindAll(prod => (prod.Weight >= minWeight) && (prod.Weight <= maxWeight) && (prod.Volume >= minVolume) && (prod.Volume <= maxVolume) && (prod.Price >= minPrice) && (prod.Price <= maxPrice));
        
        //}
    }
}
