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

            

            unitOfWork.ProductRepository.GetAllTypes().ToList().ForEach(type => Console.WriteLine(type.ID + " " + type.DeliveryType));

            unitOfWork.TransportRepository.GetAll().ToList().ForEach(trans =>Console.WriteLine( trans.ID + " " + trans.Speed + " " + trans.DeliveryType + " " + trans.DeliveryType.ID));

            //unitOfWork.TransportRepository.GetAll().ToList().ForEach(transport => Console.WriteLine(transport.DeliveryType.DeliveryType + " " + transport.Speed));

            //unitOfWork.OrderRepository.GetAll().ToList().ForEach(order => Console.WriteLine(order.Destination.Name + " " + order.Product.Name + order.Time_Of_Ordering));

            //unitOfWork.OrderRepository.Delete(1);

            unitOfWork.Complete();

            unitOfWork.Dispose();

            Console.WriteLine("=========");
            Console.ReadKey();

        }
    }
}
