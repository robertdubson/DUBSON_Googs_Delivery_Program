using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class FragileProduct : Product
    {
        public FragileProduct(int ID, string name, double weight, double volume, double price, double timeForPreparation) : base(name, weight, volume, price, timeForPreparation) { }
    
    }
}
