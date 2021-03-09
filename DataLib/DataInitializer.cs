using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DataLib
{
    public class DataInitializer
    {
        public DestinationRepository destinationRepository { get; set; }
        public TransportRepository transportRepository { get; set; }

        public OrderRepository orderRepository { get; set; }

        public ProductRepository productRepository { get; set; }

        public DataInitializer() {

            destinationRepository = new DestinationRepository();

            destinationRepository.EntitiesFromDataSourse = new List<DestinationEntity>();

            

            transportRepository = new TransportRepository();

            transportRepository.EntitiesFromDataSourse = new List<TransportEntity>();

            

            productRepository = new ProductRepository();

            productRepository.EntitiesFromDataSourse = new List<ProductEntity>();

            
        }
    }
}
