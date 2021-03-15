﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DataLib
{
    public interface IProductRepository : IRepository<ProductEntity>
    {
        List<DeliveryTypeEntity> typesOfDelivery { get; set; }
        List<DeliveryTypeEntity> GetAllTypes();
    }
}
