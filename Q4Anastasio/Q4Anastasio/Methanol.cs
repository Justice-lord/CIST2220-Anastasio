using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4Anastasio
{
    public class Methanol : EnergyTypeBase
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double SpecificEnergy { get; set; }
        public double EnergyDensity { get; set; }

        public Methanol()
        {
            Name = "Methanol";
            Type = "Chemical fuel";
            SpecificEnergy = 19.9;
            EnergyDensity = 15.8;
        }

        public override string GetName()
        {
            return Name;
        }

        public override string GetEnergyType()
        {
            return Type;
        }

        public override double GetEnergyDensity()
        {
            return EnergyDensity;
        }

        public override double GetSpecificEnergy()
        {
            return SpecificEnergy;
        }
    }
}
