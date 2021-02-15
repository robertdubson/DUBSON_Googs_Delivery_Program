using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class TransportEntity : BaseEntity
    {
        private double _speed;

        public double Speed { get => _speed; set => _speed = value; }


    }
}
