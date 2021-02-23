using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IDestination
    {
        int ID { get; set; }

        double Distance { get; set; }

        string Name { get; set; };
    
    }
}
