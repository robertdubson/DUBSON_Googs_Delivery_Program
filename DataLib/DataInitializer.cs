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

            destinationRepository.EntitiesFromDataSourse.Add(new DestinationEntity("Kyiv", 640d));
            destinationRepository.EntitiesFromDataSourse.Add(new DestinationEntity("Harkiv", 740d));
            destinationRepository.EntitiesFromDataSourse.Add(new DestinationEntity("Dnipro", 100d));
            destinationRepository.EntitiesFromDataSourse.Add(new DestinationEntity("Lviv", 700d));
            destinationRepository.EntitiesFromDataSourse.Add(new DestinationEntity("Chernivzi", 500d));

            DeliveryTypeEntity deliveryType1 = new DeliveryTypeEntity { ID = 1, DeliveryType = "Fragile" };
            DeliveryTypeEntity deliveryType2 = new DeliveryTypeEntity { ID = 2, DeliveryType = "SuperHeavy" };
            DeliveryTypeEntity deliveryType3 = new DeliveryTypeEntity { ID = 3, DeliveryType = "Usual" };
            DeliveryTypeEntity deliveryType4 = new DeliveryTypeEntity { ID = 4, DeliveryType = "FoodDelivery" };


            orderRepository = new OrderRepository();

            orderRepository.EntitiesFromDataSourse = new List<OrderEntity>();

            

            transportRepository = new TransportRepository();

            transportRepository.EntitiesFromDataSourse = new List<TransportEntity>();

            transportRepository.Add(new TransportEntity(65d, deliveryType1));
            transportRepository.Add(new TransportEntity(65d, deliveryType2));
            transportRepository.Add(new TransportEntity(65d, deliveryType3));
            transportRepository.Add(new TransportEntity(65d, deliveryType3));
            transportRepository.Add(new TransportEntity(65d, deliveryType3));
            transportRepository.Add(new TransportEntity(65d, deliveryType1));
            transportRepository.Add(new TransportEntity(65d, deliveryType1));

            productRepository = new ProductRepository();

            productRepository.EntitiesFromDataSourse = new List<ProductEntity>();

            productRepository.typesOfDelivery = new List<DeliveryTypeEntity>();

            productRepository.typesOfDelivery.Add(deliveryType1);
            productRepository.typesOfDelivery.Add(deliveryType2);
            productRepository.typesOfDelivery.Add(deliveryType3);
            productRepository.typesOfDelivery.Add(deliveryType4);

            productRepository.EntitiesFromDataSourse.Add(new ProductEntity("Laptop", 4, 5, 3000, 200d, deliveryType3));
            productRepository.EntitiesFromDataSourse.Add(new ProductEntity("Fridge", 4, 5, 4500, 100d, deliveryType2));
            productRepository.EntitiesFromDataSourse.Add(new ProductEntity("Table", 4, 5, 3000, 150d, deliveryType2));
        }
    }
}
