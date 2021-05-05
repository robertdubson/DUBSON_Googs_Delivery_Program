using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Entity;
using Model;

namespace Mappers
{
    public class ProductMapper : IMapper<ProductEntity, Product, ProductModel>
    {
        DeliveryTypeMapper deliveryTypeMapper;

        public ProductMapper() {

            deliveryTypeMapper = new DeliveryTypeMapper();
        
        }

        
        
        public Product FromEntityToDomain(ProductEntity entityObject) {

            return new Product
            {

                ID = entityObject.ID,
                //Weight = productFromDB.Weight,
                Name = entityObject.Name,
                Weight = entityObject.Weight,
                Volume = entityObject.Volume,
                Price = entityObject.Price,
                //Volume = productFromDB.Volume,
                TimeForPreparation = entityObject.TimeForPreparation,
                Type = deliveryTypeMapper.FromEntityToDomain(entityObject.DeliveryType)

            };
        
        }

        public ProductEntity FromDomainToEntity(Product domainObject) {

            ProductEntity productForDB = new ProductEntity();

            productForDB.ID = domainObject.ID;
            productForDB.Name = domainObject.Name;
            productForDB.Price = domainObject.Price;
            productForDB.Volume = domainObject.Volume;
            productForDB.Weight = domainObject.Weight;
            productForDB.TimeForPreparation = domainObject.TimeForPreparation;
            productForDB.DeliveryType = deliveryTypeMapper.FromDomainToEntity(domainObject.Type);

            return productForDB;
        
        
        }

        public ProductModel FromDomainToModel(Product domainObject)
        {
            return new ProductModel { ID = domainObject.ID, Name = domainObject.Name, DeliveryType = deliveryTypeMapper.FromDomainToModel(domainObject.Type), Price = domainObject.Price, TimeForPreparation = domainObject.TimeForPreparation, Volume = domainObject.Volume, Weight = domainObject.Weight };
        }

        public Product FromModelToDomain(ProductModel modelObject)
        {
            return new Product { ID = modelObject.ID, Type = deliveryTypeMapper.FromModelToDomain(modelObject.DeliveryType), Name = modelObject.Name, Price = modelObject.Price, TimeForPreparation = modelObject.TimeForPreparation, Volume = modelObject.Volume, Weight = modelObject.Weight };
        }
    }
}
