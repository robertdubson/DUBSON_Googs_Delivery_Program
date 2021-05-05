using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mappers;
using DataLib;
using Entity;


namespace Services
{
    public class DestinationService : IDestinationService
    {
        private readonly IDestinationRepository _destinationRepository;

        DestinationMapper _destinationMapper;

        public DestinationService(IDestinationRepository repository) {

            _destinationRepository = repository;

            _destinationMapper = new DestinationMapper();
        
        }

        
        public void AddDestination(Destination destination)
        {
            _destinationRepository.Add(_destinationMapper.FromDomainToEntity(destination));
        }

        public void DeleteDestination(int ID)
        {
            _destinationRepository.Delete(ID);
        }

        public List<Destination> GetAllDestinations()
        {
            return _destinationRepository.GetAll().Select(dest => _destinationMapper.FromEntityToDomain(dest)).ToList();
        }

        public Destination GetDestinationByID(int ID)
        {
            return _destinationMapper.FromEntityToDomain(_destinationRepository.GetByID(ID));
        }

        
    }
}
