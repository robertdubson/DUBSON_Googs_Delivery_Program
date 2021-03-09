using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Entity;

namespace Mappers
{
    public class ProductMapper
    {
        DeliveryTypeMapper deliveryTypeMapper;

        public ProductMapper() {

            deliveryTypeMapper = new DeliveryTypeMapper();
        
        }

        
        
        public IProduct FromEntityToDomain(ProductEntity productFromDB) {

            return new Product
            {

                ID = productFromDB.ID,
                //Weight = productFromDB.Weight,
                Name = productFromDB.Name,
                Weight = productFromDB.Weight,
                Volume = productFromDB.Volume,
                Price = productFromDB.Price,
                //Volume = productFromDB.Volume,
                TimeForPreparation = productFromDB.TimeForPreparation,
                Type = deliveryTypeMapper.FromEntityToDomain(productFromDB.DeliveryType)

            };
        
        }

        public ProductEntity FromDomainToEntity(IProduct productFromDomain) {

            ProductEntity productForDB = new ProductEntity();

            productForDB.ID = productFromDomain.ID;
            productForDB.Name = productFromDomain.Name;
            productForDB.Price = productFromDomain.Price;
            productForDB.Volume = productFromDomain.Volume;
            productForDB.Weight = productFromDomain.Weight;
            productForDB.TimeForPreparation = productFromDomain.TimeForPreparation;
            productForDB.DeliveryType = deliveryTypeMapper.FromDomainToEntity(productFromDomain.Type);

            return productForDB;
        
        
        }
    }
}
