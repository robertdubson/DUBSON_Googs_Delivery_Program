﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.Entity;
namespace DataLib
{
    public class TransportRepository : Repository<TransportEntity, int>, ITransportRepository
    {
        DbSet<DeliveryTypeEntity> deliveryTypes;

        public TransportRepository(DbContext context) : base(context) {

            _DbSet = context.Set<TransportEntity>();

            deliveryTypes = context.Set<DeliveryTypeEntity>();

            //_DbSet.Include(transport => transport.DeliveryType).ToList();

           _DbSet.Include(transport => transport.DeliveryType).ToList();
           _DbSet.Include(transport => transport.TransportType).ToList();
        
        }


        //List<TransportEntity> IRepository<TransportEntity>.Context { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        

        

    }
}
