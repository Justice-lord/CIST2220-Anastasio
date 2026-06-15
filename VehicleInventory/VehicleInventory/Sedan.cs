using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInventory
{
    internal class Sedan : Vehicle
    {
        private int wheels = 4;
        public override int Wheels
        {
            get { return wheels; }
        }

        public override int MaxPassengers
        {
            get
            {
                return 5;
            }
        }

        public override string GetDescription()
        {
            return $"Sedan License Plate: {LicensePlate} VIN: {VIN} Wheels: {wheels} Passengers: {MaxPassengers}";
        }

        public override string ToString()
        {
            return $"Sedan License Plate: {LicensePlate} VIN: {VIN}";
        }
    }
}
