using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
namespace Services.Strategy
{
    public class PreprocessedOrder
    {
        public Destination Destination { get; set; }

        public Product Product { get; set; }

        public List<Transport> SuitableTransport { get; set; }

        public PreprocessedOrder(Destination destination, Product product, List<Transport> suitableTransport) {

            Destination = destination;

            Product = product;

            SuitableTransport = suitableTransport;
        
        
        }
    }
}
