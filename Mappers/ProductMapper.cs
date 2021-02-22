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
        public IProduct FromEntityToDomain(ProductEntity productFromDB) {

            if (productFromDB.Volume > 1000)
            {

                return new OversizedProduct(productFromDB.Name, productFromDB.Weight, productFromDB.Volume, productFromDB.Price, productFromDB.TimeForPreparation);

            }

            else if (productFromDB.Weight > 950)
            {

                return new HeavyProduct(productFromDB.Name, productFromDB.Weight, productFromDB.Volume, productFromDB.Price, productFromDB.TimeForPreparation);

            }

            else if (productFromDB.Price > 1000)
            {

                return new FragileProduct(productFromDB.Name, productFromDB.Weight, productFromDB.Volume, productFromDB.Price, productFromDB.TimeForPreparation);

            }

            else {

                
                return new Product(productFromDB.Name, productFromDB.Weight, productFromDB.Volume, productFromDB.Price, productFromDB.TimeForPreparation);
            
            }
        
        }

        public ProductEntity FromDomainToEntity(IProduct productFromDomain) {

            ProductEntity productForDB = new ProductEntity();

            productForDB.Name = productFromDomain.Name;
            productForDB.Price = productFromDomain.Price;
            productForDB.Volume = productFromDomain.Volume;
            productForDB.Weight = productFromDomain.Weight;

            return productForDB;
        
        
        }
    }
}
