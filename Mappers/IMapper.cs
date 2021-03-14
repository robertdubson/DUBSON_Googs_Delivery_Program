using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers
{
    public interface IMapper<Entity, Domain, Model>
    {
        Domain FromEntityToDomain(Entity entityObject);

        Entity FromDomainToEntity(Domain domainObject);

        Model FromDomainToModel(Domain domainObject);

        Domain FromModelToDomain(Model modelObject);
        
        
        
    }
}
