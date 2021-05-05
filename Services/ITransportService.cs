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
    public interface ITransportService
    {
        void Add(Transport transport);

        Transport GetTransportByID(int ID);

        void DeleteTransport(int ID);

        void UpdateTransport(Transport transport);

        List<Transport> GetSuitableTransport(Product product);

        List<Transport> GetAllTransports();

    }
}
