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

        public ProductService(IProductRepository repository) {

            _productRepository = repository;

            _productMapper = new ProductMapper();
        
        }

        public void AddProduct(IProduct product)
        {
            _productRepository.Add(_productMapper.FromDomainToEntity(product));
        }

        public void DeleteProduct(int ID)
        {
            _productRepository.Delete(ID);
        }

        public List<IProduct> GetAllProducts()
        {
            return _productRepository.EntitiesFromDataSourse.Select(prod => _productMapper.FromEntityToDomain(prod)).ToList();
        }

        public IProduct GetProductByID(int ID)
        {
            return _productMapper.FromEntityToDomain(_productRepository.GetByID(ID));
        }

        public void UpdateProduct(IProduct product)
        {
            _productRepository.Update(_productMapper.FromDomainToEntity(product));
        }
    }
}
