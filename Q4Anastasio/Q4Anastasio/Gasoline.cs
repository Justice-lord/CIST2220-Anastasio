using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4Anastasio
{
    public class Gasoline : EnergyTypeBase
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double SpecificEnergy { get; set; }
        public double EnergyDensity { get; set; }
        public Gasoline()
        {
            Name = "Gasoline";
            Type = "Chemical fuel";
            SpecificEnergy = 44.4;
            EnergyDensity = 32.4;
        }

        public override string GetName()
        {
            return Name;
        }

        public override string GetEnergyType()
        {
            return Type;
        }

        public override double GetSpecificEnergy()
        {
            return SpecificEnergy;
        }

        public override double GetEnergyDensity()
        {
            return EnergyDensity;
        }
    }
}
