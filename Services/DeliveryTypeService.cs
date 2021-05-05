using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib;
using Mappers;
namespace Services
{
    public class DeliveryTypeService : IDeliveryTypeService
    {
        private readonly IDeliveryTypeRepository DeliveryTypeRepository;

        DeliveryTypeMapper _deliveryTypeMapper;

        public DeliveryTypeService(IDeliveryTypeRepository repository) {

            DeliveryTypeRepository = repository;

            _deliveryTypeMapper = new DeliveryTypeMapper();
        
        }

        public void AddDeliveryType(DeliveryType deliveryType)
        {
            DeliveryTypeRepository.Add(_deliveryTypeMapper.FromDomainToEntity(deliveryType));
        }

        public void DeleteDeliveryType(DeliveryType deliveryType)
        {
            DeliveryTypeRepository.Delete(_deliveryTypeMapper.FromDomainToEntity(deliveryType));
        }

        public List<DeliveryType> GetAllDeliveryTypes()
        {
            return DeliveryTypeRepository.GetAll().ToList().Select(delType => _deliveryTypeMapper.FromEntityToDomain(delType)).ToList();
        }

        public void UpdateDeliveryType(DeliveryType deliveryType)
        {
            DeliveryTypeRepository.Update(_deliveryTypeMapper.FromDomainToEntity(deliveryType));
        }
    }
}
