using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Destination : IDestination
    {
        public double Distance { get; set; }

        public string Name { get; set; }
    }
}
