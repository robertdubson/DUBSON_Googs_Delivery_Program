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
            

            
            unitOfWork.DestinationRepository.GetAll().ToList().ForEach(dest => Console.WriteLine(dest.Name));

            unitOfWork.ProductRepository.GetAll().ToList().ForEach(prod => Console.WriteLine(prod.Name + " " + prod.Price + " " + prod.TimeForPreparation + " " + prod.Volume + " " + prod.Weight + " ") );

            unitOfWork.ProductRepository.GetAllTypes().ToList().ForEach(type => Console.WriteLine(type.DeliveryType));

            unitOfWork.Complete();

            unitOfWork.Dispose();

            Console.ReadKey();

        }
    }
}
