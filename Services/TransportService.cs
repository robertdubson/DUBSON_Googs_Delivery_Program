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

        public TransportService(ITransportRepository repository) {

            _transportRepository = repository;

            _transportMapper = new TransportMapper();
        
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

            List<ITransport> allTransports = new List<ITransport>();

            _transportRepository.EntitiesFromDataSourse.ForEach(transport => allTransports.Add(_transportMapper.FromEntityToDomain(transport)));

            return allTransports;

        }
    }
}
