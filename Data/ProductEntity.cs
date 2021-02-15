using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ProductEntity : BaseEntity
    {
        private string _name;

        public string Name { get => _name; set => _name = value; }
        
        private double _weight;

        public double Weight { get => _weight; set => _weight = value; }

        private double _volume;

        public double Volume { get => _volume; set => _volume = value; }

        private double _price;

        public double Price { get => _price; set => _price = value; }

        private double _time_For_Preparation;

        public double TimeForPreparation { get => _time_For_Preparation; set => _time_For_Preparation = value; }

    }
}
