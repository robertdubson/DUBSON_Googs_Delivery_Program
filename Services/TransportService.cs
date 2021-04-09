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

        

        public List<ITransport> GetAllTransports() {

            return _transportRepository.GetAll().Select(transport => _transportMapper.FromEntityToDomain(transport)).ToList();
        }

        public List<ITransport> GetSuitableTransport(IProduct product) {

            // повертаємо усі одиниці транспорту, що підходять для перевезення продукту отриманого типу
            
            return _transportRepository.GetAll().ToList().FindAll(transport => transport.DeliveryType.ID == _productMapper.FromDomainToEntity(product).DeliveryType.ID).Select(transport => _transportMapper.FromEntityToDomain(transport)).ToList();
        
        }

        public void UpdateTransport(ITransport transport) {

            _transportRepository.GetByID(transport.ID).InTheShop = _transportMapper.FromDomainToEntity(transport).InTheShop;

            _transportRepository.GetByID(transport.ID).Speed = _transportMapper.FromDomainToEntity(transport).Speed;

            _transportRepository.GetByID(transport.ID).DeliveryType = _transportMapper.FromDomainToEntity(transport).DeliveryType;

        }
        
    }
}
