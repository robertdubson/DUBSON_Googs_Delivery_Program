﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface ITransport
    {
        int ID { get; set; }
        double Speed { get; set; }

    }
}