using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataLib;
using DataLib.UnitOfWork;
using Entity;
namespace TestForEF
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new ApplicationContext());

            // DestinationEntity dest1 = new DestinationEntity { Name = "Kriviy Rih", DistanceFromCenter = 200, ID=1 };

            //unitOfWork.DestinationRepository.Add(dest1);

            //DeliveryTypeEntity fragile = new DeliveryTypeEntity() { DeliveryType = "fragile" };

            //unitOfWork.ProductRepository.AddNewType(fragile);

            //unitOfWork.ProductRepository.Add(new ProductEntity() { DeliveryType= fragile, Name = "Glass plates Collection", Price = 13450, TimeForPreparation = 40, Volume = 50, Weight = 60 });

            // DeliveryTypeEntity defaultType = new DeliveryTypeEntity() { DeliveryType = "Default" };


            // unitOfWork.ProductRepository.AddNewType(defaultType);

            // unitOfWork.Complete();

            //unitOfWork.ProductRepository.Add(new ProductEntity() { DeliveryType = unitOfWork.ProductRepository.FindTypeByID(2), Name = "Game of Thrones by Tolkin", Price = 400, TimeForPreparation = 30, Volume = 3, Weight = 4 });

            //unitOfWork.ProductRepository.Delete(3);

            //unitOfWork.DestinationRepository.GetAll().ToList().ForEach(dest => Console.WriteLine(dest.Name));

            //unitOfWork.ProductRepository.Add(new ProductEntity() {Name = "Table", DeliveryType = unitOfWork.ProductRepository.FindTypeByID(2), Price = 13450, TimeForPreparation = 20, Volume = 50, Weight = 30 });
            //unitOfWork.ProductRepository.AddNewType(new DeliveryTypeEntity() { DeliveryType = "ExtraHeavy"});

            //unitOfWork.ProductRepository.AddNewType(new DeliveryTypeEntity() { DeliveryType = "Liquid" });

            //unitOfWork.ProductRepository.AddNewType(new DeliveryTypeEntity() { DeliveryType = "Flammable" });

            //unitOfWork.ProductRepository.GetAll().ToList().ForEach(prod => Console.WriteLine(prod.ID + " " + prod.Name));

            //unitOfWork.DestinationRepository.GetAll().ToList().ForEach(dest => Console.WriteLine(dest.ID + " " + dest.Name));

            //unitOfWork.OrderRepository.Add(new OrderEntity(new DestinationEntity() { Name = "kkkk"}, new ProductEntity() { Name = "dfghj"}, DateTime.Now, 12.3, new TransportEntity { Speed = 12}));

            //  TransportTypeEntity type1 = new TransportTypeEntity() { Type = "Truck" };

            //  TransportTypeEntity type2 = new TransportTypeEntity() { Type = "Bicycle"};

            //  TransportTypeEntity type3 = new TransportTypeEntity() { Type = "Car" };

            //  unitOfWork.TransportTypeRepository.Add(type1);

            //  unitOfWork.TransportTypeRepository.Add(type2);

            //  unitOfWork.TransportTypeRepository.Add(type2);

            //  DeliveryTypeEntity deliveryType1 = unitOfWork.DeliveryTypeRepository.GetByID(1);

            //  DeliveryTypeEntity deliveryType2 = unitOfWork.DeliveryTypeRepository.GetByID(2);

            //  DeliveryTypeEntity deliveryType3 = unitOfWork.DeliveryTypeRepository.GetByID(3);

            //  DeliveryTypeEntity deliveryType4 = unitOfWork.DeliveryTypeRepository.GetByID(4);

            // DeliveryTypeEntity deliveryType5 = unitOfWork.DeliveryTypeRepository.GetByID(5);

            // TransportEntity car1 = new TransportEntity { Speed=70, DeliveryType = deliveryType2, TransportType = type3, InTheShop = true };

            // TransportEntity car2 = new TransportEntity { Speed = 70, DeliveryType = deliveryType2, TransportType = type3, InTheShop = true };

            // TransportEntity car3 = new TransportEntity { Speed = 70, DeliveryType = deliveryType2, TransportType = type3, InTheShop = true };

            // TransportEntity car4 = new TransportEntity { Speed = 70, DeliveryType = deliveryType2, TransportType = type3, InTheShop = true };

            // TransportEntity truck1 = new TransportEntity { Speed = 70, DeliveryType = deliveryType3, TransportType = type1, InTheShop = true };

            // TransportEntity truck2 = new TransportEntity { Speed = 70, DeliveryType = deliveryType3, TransportType = type1, InTheShop = true };

            // TransportEntity truck3 = new TransportEntity { Speed = 70, DeliveryType = deliveryType3, TransportType = type1, InTheShop = true };

            // TransportEntity truck4 = new TransportEntity { Speed = 70, DeliveryType = deliveryType5, TransportType = type1, InTheShop = true };

            // TransportEntity truck5 = new TransportEntity { Speed = 70, DeliveryType = deliveryType5, TransportType = type1, InTheShop = true };

            // TransportEntity truck6 = new TransportEntity { Speed = 70, DeliveryType = deliveryType5, TransportType = type1, InTheShop = true };

            // TransportEntity bicycle1 = new TransportEntity { Speed = 30, DeliveryType = deliveryType4, TransportType = type2, InTheShop = true };

            // TransportEntity bicycle2 = new TransportEntity { Speed = 30, DeliveryType = deliveryType4, TransportType = type2, InTheShop = true };

            // TransportEntity bicycle3 = new TransportEntity { Speed = 30, DeliveryType = deliveryType4, TransportType = type2, InTheShop = true };

            // TransportEntity car5 = new TransportEntity { Speed = 70, DeliveryType = deliveryType1, TransportType = type3, InTheShop = true };

            // TransportEntity car6 = new TransportEntity { Speed = 70, DeliveryType = deliveryType1, TransportType = type3, InTheShop = true };

            //TransportEntity car7 = new TransportEntity { Speed = 70, DeliveryType = deliveryType1, TransportType = type3, InTheShop = true };

            //unitOfWork.TransportRepository.Add(car1);

            // unitOfWork.TransportRepository.Add(car2);

            // unitOfWork.TransportRepository.Add(car3);

            // unitOfWork.TransportRepository.Add(car4);

            // unitOfWork.TransportRepository.Add(car5);

            // unitOfWork.TransportRepository.Add(car6);

            // unitOfWork.TransportRepository.Add(car7);

            // unitOfWork.TransportRepository.Add(truck1);

            // unitOfWork.TransportRepository.Add(truck2);

            // unitOfWork.TransportRepository.Add(truck3);

            // unitOfWork.TransportRepository.Add(truck4);

            // unitOfWork.TransportRepository.Add(truck5);

            // unitOfWork.TransportRepository.Add(truck6);

            // unitOfWork.TransportRepository.Add(bicycle1);

            // unitOfWork.TransportRepository.Add(bicycle2);

            // unitOfWork.TransportRepository.Add(bicycle3);



            //unitOfWork.ProductRepository.GetAllTypes().ToList().ForEach(type => Console.WriteLine(type.ID + " " + type.DeliveryType));

            //unitOfWork.TransportRepository.GetAll().ToList().ForEach(trans =>Console.WriteLine( trans.ID + " " + trans.Speed + " " + trans.DeliveryType + " " + trans.DeliveryType.ID));

            //unitOfWork.TransportRepository.GetAll().ToList().ForEach(transport => Console.WriteLine(transport.DeliveryType.DeliveryType + " " + transport.Speed));

            //unitOfWork.OrderRepository.GetAll().ToList().ForEach(order => Console.WriteLine(order.Destination.Name + " " + order.Product.Name + order.Time_Of_Ordering));

            //unitOfWork.OrderRepository.Delete(1);

            unitOfWork.ProductRepository.GetAll().ToList().ForEach(prod => Console.WriteLine(prod.DeliveryType));

            unitOfWork.TransportRepository.GetAll().ToList().ForEach(transport => Console.WriteLine(transport.DeliveryType.DeliveryType));

            unitOfWork.TransportRepository.GetAll().ToList().ForEach(transport => Console.WriteLine(transport.TransportType.Type));

            unitOfWork.Complete();

            unitOfWork.Dispose();

            Console.WriteLine("=========");
            Console.ReadKey();

        }
    }
}
