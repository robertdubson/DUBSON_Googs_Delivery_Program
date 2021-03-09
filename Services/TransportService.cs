using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DataLib;
using Entity;
using Mappers;

namespace Services
{
    public class TransportService : ITransportService
    {
        private readonly ITransportRepository _transportRepository;

        TransportMapper _transportMapper;

        ProductMapper _productMapper;

        public TransportService(ITransportRepository repository) {

            _transportRepository = repository;

            _transportMapper = new TransportMapper();

            _productMapper = new ProductMapper();
        
        }

        public void Add(ITransport transport)
        {
            _transportRepository.Add(_transportMapper.FromDomainToEntity(transport));
        }

        public void DeleteTransport(int ID)
        {
            _transportRepository.Delete(ID);
        }

        public ITransport GetTransportByID(int ID)
        {
            return _transportMapper.FromEntityToDomain(_transportRepository.GetByID(ID));
        }

        public void UdateTransport(ITransport transport)
        {
            _transportRepository.Update(_transportMapper.FromDomainToEntity(transport));
        }

        public List<ITransport> GetAllTransports() {

            return _transportRepository.EntitiesFromDataSourse.Select(transport => _transportMapper.FromEntityToDomain(transport)).ToList();
        }

        public List<ITransport> GetSuitableTransport(IProduct product) {

            // повертаємо усі одиниці транспорту, що підходять для перевезення продукту отриманого типу
            
            return _transportRepository.EntitiesFromDataSourse.FindAll(transport => transport.DeliveryType.Equals(_productMapper.FromDomainToEntity(product).DeliveryType)).Select(transport => _transportMapper.FromEntityToDomain(transport)).ToList();
        
        }
        
    }
}
