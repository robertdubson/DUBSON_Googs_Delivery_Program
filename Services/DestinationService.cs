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

        
        public void AddDestination(IDestination destination)
        {
            _destinationRepository.Add(_destinationMapper.FromDomainToEntity(destination));
        }

        public void DeleteDestination(int ID)
        {
            _destinationRepository.Delete(ID);
        }

        public List<IDestination> GetAllDestinations()
        {
            List<IDestination> allDestinations = new List<IDestination>();

            _destinationRepository.EntitiesFromDataSourse.ForEach(dest => _destinationMapper.FromEntityToDomain(dest));

            return allDestinations;
        }

        public IDestination GetDestinationByID(int ID)
        {
            return _destinationMapper.FromEntityToDomain(_destinationRepository.GetByID(ID));
        }

        public void UpdateDestination(IDestination destination)
        {
            _destinationRepository.Update(_destinationMapper.FromDomainToEntity(destination));
        }
    }
}
