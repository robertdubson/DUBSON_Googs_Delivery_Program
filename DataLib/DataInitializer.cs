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

            destinationRepository.EntitiesFromDataSourse.Add(new DestinationEntity("Kiev", 123));
            
            destinationRepository.EntitiesFromDataSourse.Add(new DestinationEntity("Zelenodolsk", 121));
            
            destinationRepository.EntitiesFromDataSourse.Add(new DestinationEntity("Odessa", 126));
            
            destinationRepository.EntitiesFromDataSourse.Add(new DestinationEntity("Lviv", 113));

            destinationRepository.EntitiesFromDataSourse.Add(new DestinationEntity("Kriviy Rih", 209));

            transportRepository = new TransportRepository();

            transportRepository.EntitiesFromDataSourse = new List<TransportEntity>();

            transportRepository.EntitiesFromDataSourse.Add(new TransportEntity(75, TransportType.Car));

            transportRepository.EntitiesFromDataSourse.Add(new TransportEntity(75, TransportType.Car));
            
            transportRepository.EntitiesFromDataSourse.Add(new TransportEntity(75, TransportType.Car));
            
            transportRepository.EntitiesFromDataSourse.Add(new TransportEntity(75, TransportType.Car));
            
            transportRepository.EntitiesFromDataSourse.Add(new TransportEntity(75, TransportType.Car));

            transportRepository.EntitiesFromDataSourse.Add(new TransportEntity(50, TransportType.Truck));

            transportRepository.EntitiesFromDataSourse.Add(new TransportEntity(50, TransportType.Truck));

            transportRepository.EntitiesFromDataSourse.Add(new TransportEntity(50, TransportType.Truck));

            transportRepository.EntitiesFromDataSourse.Add(new TransportEntity(70, TransportType.ProtectedVehicle));

            transportRepository.EntitiesFromDataSourse.Add(new TransportEntity(70, TransportType.ProtectedVehicle));

            productRepository = new ProductRepository();

            productRepository.EntitiesFromDataSourse = new List<ProductEntity>();

            productRepository.EntitiesFromDataSourse.Add(new ProductEntity("NoteBook", 4, 120, 4500));

            productRepository.EntitiesFromDataSourse.Add(new ProductEntity("Camera", 2, 20, 3000));

            productRepository.EntitiesFromDataSourse.Add(new ProductEntity("Table", 500, 1000, 6400));






        }
    }
}
