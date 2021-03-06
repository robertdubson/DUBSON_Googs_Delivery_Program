﻿using System;
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

        /*
            destinationRepository = new DestinationRepository();

            destinationRepository.Context = new List<DestinationEntity>();

            destinationRepository.Context.Add(new DestinationEntity("Kyiv", 640.0));
            destinationRepository.Context.Add(new DestinationEntity("Harkiv", 740.0));
            destinationRepository.Context.Add(new DestinationEntity("Dnipro", 100.0));
            destinationRepository.Context.Add(new DestinationEntity("Lviv", 700.0));
            destinationRepository.Context.Add(new DestinationEntity("Chernivzi", 500.0));

            DeliveryTypeEntity deliveryType1 = new DeliveryTypeEntity { ID = 1, DeliveryType = "Fragile" };
            DeliveryTypeEntity deliveryType2 = new DeliveryTypeEntity { ID = 2, DeliveryType = "SuperHeavy" };
            DeliveryTypeEntity deliveryType3 = new DeliveryTypeEntity { ID = 3, DeliveryType = "Usual" };
            DeliveryTypeEntity deliveryType4 = new DeliveryTypeEntity { ID = 4, DeliveryType = "FoodDelivery" };


            orderRepository = new OrderRepository();

            orderRepository.Context = new List<OrderEntity>();

            

            transportRepository = new TransportRepository();

            transportRepository.Context = new List<TransportEntity>();

            transportRepository.Add(new TransportEntity(65.0, deliveryType1));
            transportRepository.Add(new TransportEntity(65.0, deliveryType2));
            transportRepository.Add(new TransportEntity(65.0, deliveryType3));
            transportRepository.Add(new TransportEntity(65.0, deliveryType3));
            transportRepository.Add(new TransportEntity(65.0, deliveryType3));
            transportRepository.Add(new TransportEntity(65.0, deliveryType1));
            transportRepository.Add(new TransportEntity(65.0, deliveryType1));

            productRepository = new ProductRepository();

            productRepository.Context = new List<ProductEntity>();

            productRepository.typesOfDelivery = new List<DeliveryTypeEntity>();

            productRepository.typesOfDelivery.Add(deliveryType1);
            productRepository.typesOfDelivery.Add(deliveryType2);
            productRepository.typesOfDelivery.Add(deliveryType3);
            productRepository.typesOfDelivery.Add(deliveryType4);

            productRepository.Context.Add(new ProductEntity("Laptop", 4, 5, 3000, 200.0, deliveryType3));
            productRepository.Context.Add(new ProductEntity("Fridge", 4, 5, 4500, 100.0, deliveryType2));
            productRepository.Context.Add(new ProductEntity("Table", 4, 5, 3000, 150.0, deliveryType2));
            */
        }
    }
}
