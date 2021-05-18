using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib;
using Mappers;
using DataLib.UnitOfWork;
namespace Services
{
    public class DeliveryTypeService : IDeliveryTypeService
    {
        

        DeliveryTypeMapper _deliveryTypeMapper;

        IUnitOfWork _unitOfWork;

        public DeliveryTypeService(IUnitOfWork unitOfWork) {

            _unitOfWork = unitOfWork;


            _deliveryTypeMapper = new DeliveryTypeMapper();

        }

        public void AddDeliveryType(DeliveryType deliveryType)
        {
            _unitOfWork.DeliveryTypeRepository.Add(_deliveryTypeMapper.FromDomainToEntity(deliveryType));

        }

        public void DeleteDeliveryType(DeliveryType deliveryType)
        {
            _unitOfWork.DeliveryTypeRepository.Delete(_deliveryTypeMapper.FromDomainToEntity(deliveryType));

        }

        public List<DeliveryType> GetAllDeliveryTypes()
        {
            return _unitOfWork.DeliveryTypeRepository.GetAll().ToList().Select(delType => _deliveryTypeMapper.FromEntityToDomain(delType)).ToList();
        }

        public void UpdateDeliveryType(DeliveryType deliveryType)
        {
            _unitOfWork.DeliveryTypeRepository.Update(_deliveryTypeMapper.FromDomainToEntity(deliveryType));
        }
    }
}
