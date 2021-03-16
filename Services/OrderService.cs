using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mappers;
using Entity;
using Domain;
using DataLib;

namespace Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        OrderMapper _orderMapper;

        TransportMapper _transportMapper;

        public OrderService(IOrderRepository repository){

            
            _orderRepository = repository;

            _orderMapper = new OrderMapper();

            _transportMapper = new TransportMapper();
        
        
        
        }
        public void AddOrder(IOrder order)
        {
            _orderRepository.Add(_orderMapper.FromDomainToEntity(order));
        }

        public void DeleteOrder(int ID)
        {
            _orderRepository.Delete(ID);
        }

        public IOrder GetOrderByID(int ID)
        {
            return _orderMapper.FromEntityToDomain(_orderRepository.GetByID(ID));
        }

        public IOrder GetOrderByInvolvedTransport(ITransport transport) {

            return _orderMapper.FromEntityToDomain(_orderRepository.GetByInvolvedTransport(_transportMapper.FromDomainToEntity(transport)));       
        
        }

        public void UpdateOrder(IOrder order)
        {
            _orderRepository.Update(_orderMapper.FromDomainToEntity(order));
        }

        public IOrder CreateAnOrder(IDestination destination, IProduct product, List<ITransport> suitableTransport) {

            List<ITransport> currentTransports = suitableTransport;

            List<DateTime> timesOfDelivery = new List<DateTime>();

            Dictionary<DateTime, ITransport> dateTransportDictionary = new Dictionary<DateTime, ITransport>();
            
            if (!suitableTransport.Select(transport => transport.InTheShop).Any())
            {
                currentTransports.ForEach(transport =>dateTransportDictionary.Add(GetOrderByInvolvedTransport(transport).TimeOfOrdering.AddSeconds(GetOrderByInvolvedTransport(transport).TimeNeededForDelivery), transport));

                List<DateTime> keysList = dateTransportDictionary.Keys.ToList();

                keysList.Sort((date1, date2) => date1.CompareTo(date2));

                DateTime theLeastTime = keysList.ElementAt(0);

                double timeNeededForDelivry = theLeastTime.Subtract(DateTime.Now).TotalSeconds + destination.Distance / dateTransportDictionary[theLeastTime].Speed + product.TimeForPreparation + GetOrderByInvolvedTransport(dateTransportDictionary[theLeastTime]).Destination.Distance / dateTransportDictionary[theLeastTime].Speed;

                return new Order(destination, dateTransportDictionary[theLeastTime], product, DateTime.Now, timeNeededForDelivry);

            }
            else {

                ITransport selectedTransport = suitableTransport.FindAll(transport => transport.InTheShop).ToList().ElementAt(0);

                double timeNeededForDelivery = 0;
                
                timeNeededForDelivery =  (double)destination.Distance / selectedTransport.Speed;

                timeNeededForDelivery = product.TimeForPreparation + timeNeededForDelivery;

                //selectedTransport.InTheShop = false;



                return new Order(destination, selectedTransport, product, DateTime.Now, timeNeededForDelivery);
            
            }
        
        }
    }
}
