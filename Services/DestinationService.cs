using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mappers;
using DataLib;
using Entity;
using DataLib.UnitOfWork;

namespace Services
{
    public class DestinationService : IDestinationService
    {
        DestinationMapper _destinationMapper;

        IUnitOfWork _unitOfWork;

        public DestinationService(IUnitOfWork unitOfWork) {

            _unitOfWork = unitOfWork;

            _destinationMapper = new DestinationMapper();

        }

        
        public void AddDestination(Destination destination)
        {
            _unitOfWork.DestinationRepository.Add(_destinationMapper.FromDomainToEntity(destination));
        }

        public void DeleteDestination(int ID)
        {
            _unitOfWork.DestinationRepository.Delete(ID);
        }

        public List<Destination> GetAllDestinations()
        {
            return _unitOfWork.DestinationRepository.GetAll().Select(dest => _destinationMapper.FromEntityToDomain(dest)).ToList();
        }

        public Destination GetDestinationByID(int ID)
        {
            return _destinationMapper.FromEntityToDomain(_unitOfWork.DestinationRepository.GetByID(ID));
        }

        
    }
}
