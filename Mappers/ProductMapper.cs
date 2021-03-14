using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Entity;

namespace Mappers
{
    public class ProductMapper : IMapper<ProductEntity, IProduct>
    {
        DeliveryTypeMapper deliveryTypeMapper;

        public ProductMapper() {

            deliveryTypeMapper = new DeliveryTypeMapper();
        
        }

        
        
        public IProduct FromEntityToDomain(ProductEntity entityObject) {

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

        public ProductEntity FromDomainToEntity(IProduct domainObject) {

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
    }
}
