using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace VehicleInventory
{
    public abstract class Vehicle
    {
        public string VIN {  get; set; }
        public string LicensePlate { get; set; }
        public abstract int Wheels { get; }
        public abstract int MaxPassengers { get; }
        public abstract string GetDescription();
    }
}
