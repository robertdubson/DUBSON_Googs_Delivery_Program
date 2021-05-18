using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DataLib;
using Entity;
using Mappers;
using DataLib.UnitOfWork;
namespace Services
{
    public class TransportService : ITransportService
    {

        TransportMapper _transportMapper;

        ProductMapper _productMapper;

        IUnitOfWork _unitOfWork;

        public TransportService(IUnitOfWork unitOfWork) {

            _unitOfWork = unitOfWork;

            _transportMapper = new TransportMapper();

            _productMapper = new ProductMapper();

        }

        public void Add(Transport transport)
        {
            _unitOfWork.TransportRepository.Add(_transportMapper.FromDomainToEntity(transport));
        }

        public void DeleteTransport(int ID)
        {
            _unitOfWork.TransportRepository.Delete(ID);
        }

        public Transport GetTransportByID(int ID)
        {
            return _transportMapper.FromEntityToDomain(_unitOfWork.TransportRepository.GetByID(ID));
        }

        

        public List<Transport> GetAllTransports() {

            return _unitOfWork.TransportRepository.GetAll().Select(transport => _transportMapper.FromEntityToDomain(transport)).ToList();
        }

        public List<Transport> GetSuitableTransport(Product product) {

            // повертаємо усі одиниці транспорту, що підходять для перевезення продукту отриманого типу
            
            return _unitOfWork.TransportRepository.GetAll().ToList().FindAll(transport => transport.DeliveryType.DeliveryType == _productMapper.FromDomainToEntity(product).DeliveryType.DeliveryType).Select(transport => _transportMapper.FromEntityToDomain(transport)).ToList();
        
        }

        public void UpdateTransport(Transport transport) {

            _unitOfWork.TransportRepository.GetByID(transport.ID).InTheShop = _transportMapper.FromDomainToEntity(transport).InTheShop;

            _unitOfWork.TransportRepository.GetByID(transport.ID).Speed = _transportMapper.FromDomainToEntity(transport).Speed;

            _unitOfWork.TransportRepository.GetByID(transport.ID).DeliveryType.DeliveryType = _transportMapper.FromDomainToEntity(transport).DeliveryType.DeliveryType;

            //_transportRepository.Update(_transportMapper.FromDomainToEntity(transport));

        }
        
    }
}
