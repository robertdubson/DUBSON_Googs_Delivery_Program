﻿using System;
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

        public void Add(Transport transport)
        {
            _transportRepository.Add(_transportMapper.FromDomainToEntity(transport));
        }

        public void DeleteTransport(int ID)
        {
            _transportRepository.Delete(ID);
        }

        public Transport GetTransportByID(int ID)
        {
            return _transportMapper.FromEntityToDomain(_transportRepository.GetByID(ID));
        }

        

        public List<Transport> GetAllTransports() {

            return _transportRepository.GetAll().Select(transport => _transportMapper.FromEntityToDomain(transport)).ToList();
        }

        public List<Transport> GetSuitableTransport(Product product) {

            // повертаємо усі одиниці транспорту, що підходять для перевезення продукту отриманого типу
            
            return _transportRepository.GetAll().ToList().FindAll(transport => transport.DeliveryType.DeliveryType == _productMapper.FromDomainToEntity(product).DeliveryType.DeliveryType).Select(transport => _transportMapper.FromEntityToDomain(transport)).ToList();
        
        }

        public void UpdateTransport(Transport transport) {

            _transportRepository.GetByID(transport.ID).InTheShop = _transportMapper.FromDomainToEntity(transport).InTheShop;

            _transportRepository.GetByID(transport.ID).Speed = _transportMapper.FromDomainToEntity(transport).Speed;

            _transportRepository.GetByID(transport.ID).DeliveryType.DeliveryType = _transportMapper.FromDomainToEntity(transport).DeliveryType.DeliveryType;

            //_transportRepository.Update(_transportMapper.FromDomainToEntity(transport));

        }
        
    }
}
