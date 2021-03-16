using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DestinationModel
    {
        public double Distance { get; set; }

        public string Name { get; set; }

        public int ID { get; set; }

        public override string ToString()
        {
            return Name + Distance + " km";
        }
    }
}
