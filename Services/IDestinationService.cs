using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Entity;
using DataLib;

namespace Services
{
    public interface IDestinationService
    {
        void AddDestination(IDestination destination);

        IDestination GetDestinationByID(int ID);

        void DeleteDestination(int ID);

        void UpdateDestination(IDestination destination);

        List<IDestination> GetAllDestinations();
    }
}
