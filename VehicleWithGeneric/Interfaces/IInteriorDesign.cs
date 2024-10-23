﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleWithGeneric.Interfaces
{
    public interface IInteriorDesign<T>
    {
        string[] GetInteriordesins<T>(string data);
    }
}
