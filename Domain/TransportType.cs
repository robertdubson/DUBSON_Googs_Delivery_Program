using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TransportType : ITransportType
    {
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Type { get; set; }
    }
}
