using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers
{
    public interface IMapper<EntityClass, DomainClass>
    {
        DomainClass FromEntityToDomain(EntityClass entityObject);

        EntityClass FromDomainToEntity(DomainClass domainObject);
        
        
        
    }
}
