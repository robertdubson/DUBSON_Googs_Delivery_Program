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

        private readonly IDeliveryTypeRepository _deliveryTypeRepository;

        DeliveryTypeMapper _deliveryTypeMapper;

        public DeliveryTypeService(IDeliveryTypeRepository deliveryTypeRepository) {

            _deliveryTypeRepository = deliveryTypeRepository;

            _deliveryTypeMapper = new DeliveryTypeMapper();        
        }

        public void AddDeliveryType(IDeliveryType deliveryType)
        {
            _deliveryTypeRepository.Add(_deliveryTypeMapper.FromDomainToEntity(deliveryType));   
        }

        public void DeleteDeliveryType(IDeliveryType deliveryType)
        {
            _deliveryTypeRepository.Delete(_deliveryTypeMapper.FromDomainToEntity(deliveryType));
        }

        public List<IDeliveryType> GetAllDeliveryTypes()
        {
            return _deliveryTypeRepository.GetAll().ToList().Select(delType => _deliveryTypeMapper.FromEntityToDomain(delType)).ToList();
        }

        public void UpdateDeliveryType(IDeliveryType deliveryType)
        {
            _deliveryTypeRepository.Update(_deliveryTypeMapper.FromDomainToEntity(deliveryType));
        }
    }
}
