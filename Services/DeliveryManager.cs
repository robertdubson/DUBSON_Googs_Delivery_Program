using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;


namespace Services
{
    public class DeliveryManager
    {
        List<ITransport> _availableTransports;

        List<ITransport> _busyTransport;

        List<IProduct> _availableProducts;

        List<IDestination> _destinations;

        public DeliveryManager(List<ITransport> availableTransports, List<IProduct> products, List<IDestination> destinations) {

            _availableTransports = availableTransports;

            _availableProducts = products;

            _destinations = destinations;
                
        }

        public void CreateAnOrder(DateTime timeOfAnOrder, IProduct product, IDestination destination) {


            double timeOfDelivery = CountTheTime(ProcessTheOrder(product), destination, product);

            IOrder currentOrder = new Order() { Destination = destination,

                Product = product,

                TimeNeededForDelivery = timeOfDelivery,

                TimeOfOrdering = DateTime.Now

            };

        }

        public double CountTheTime(ITransport transport, IDestination destination, IProduct product) {

            return destination.Distance / transport.Speed + product.TimeForPreparation;
        
        }

        public ITransport ProcessTheOrder(IProduct product) {

            ITransport availableVehicle = new Car();

            
            availableVehicle = _availableTransports.Find(tr => tr is Car );

            if (availableVehicle == null)
            {



                return availableVehicle;
            }

            else {


                return availableVehicle;
            
            }
        
        }

        public ITransport ProcessTheOrder(FragileProduct product) {

            ITransport availableVehicle = new ProtectedVehicle();

            availableVehicle = _availableTransports.Find(tr => tr is ProtectedVehicle);

            if (availableVehicle == null)
            {

                return availableVehicle;
            }
            else {

                return availableVehicle;
            
            }

        }

        public ITransport ProcessTheOrder(HeavyProduct product) {

            ITransport availableVehicle = new Truck();

            availableVehicle = _availableTransports.Find(tr => tr is Truck);

            if (availableVehicle == null) { 
            
            
            }    
            
            return availableVehicle;
        
        }
    }
}
