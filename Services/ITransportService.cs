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
        void Add(ITransport transport);

        ITransport GetTransportByID(int ID);

        void DeleteTransport(int ID);

        void UpdateTransport(ITransport transport);

        List<ITransport> GetSuitableTransport(IProduct product);

        List<ITransport> GetAllTransports();

    }
}
