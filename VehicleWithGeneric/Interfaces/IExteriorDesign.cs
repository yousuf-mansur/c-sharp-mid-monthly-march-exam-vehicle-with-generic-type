using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleWithGeneric.Entities;

namespace VehicleWithGeneric.Interfaces
{
    public interface IExteriorDesign<T> where T : Vehicle
    {
        string[] GetExteriorDesigns<T>(string data) where T : Vehicle;
    }
}
