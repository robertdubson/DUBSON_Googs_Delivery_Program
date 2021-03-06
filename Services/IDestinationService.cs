﻿using System;
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
        void AddDestination(Destination destination);

        Destination GetDestinationByID(int ID);

        void DeleteDestination(int ID);

        

        List<Destination> GetAllDestinations();
    }
}
