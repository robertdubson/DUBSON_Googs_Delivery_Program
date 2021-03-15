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

        public List<DeliveryType> GetAllTypes()
        {
            return _productRepository.GetAllTypes().Select(deliveryType => _deliveryTypeMapper.FromEntityToDomain(deliveryType)).ToList();
        }

        public IProduct GetProductByID(int ID)
        {
            return _productMapper.FromEntityToDomain(_productRepository.GetByID(ID));
        }

        public void UpdateProduct(IProduct product)
        {
            _productRepository.Update(_productMapper.FromDomainToEntity(product));
        }

        public List<IProduct> GetProductsByType(DeliveryType delType) {

            return _productRepository.EntitiesFromDataSourse.FindAll(prod => prod.DeliveryType.DeliveryType == _deliveryTypeMapper.FromDomainToEntity(delType).DeliveryType).Select(prod => _productMapper.FromEntityToDomain(prod)).ToList();
        
        }
    }
}
