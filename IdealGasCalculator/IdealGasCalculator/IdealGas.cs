using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IdealGasCalculator
{
    internal class IdealGas
    {
        // private fields
        private double mass;
        private double volume;
        private double temp;
        private double moleWeight;
        private double pressure;

        // Accessors and Mutators
        public double GetMass()
        {
            return mass;
        }
        public void SetMass(double newMass)
        {
            this.mass = newMass;
            Calc();
        }

        public double GetVolume()
        {
            return volume;
        }
        public void SetVolume(double newVolume)
        {
            this.volume = newVolume;
            Calc();
        }

        public double GetTemp()
        {
            return temp;
        }
        public void SetTemp(double newTemp)
        {
            this.temp = newTemp;
            Calc();
        }

        public double GetMoleWeight()
        {
            return moleWeight;
        }
        public void SetMoleWeight(double newMoleWeight)
        {
            this.moleWeight = newMoleWeight;
            Calc();
        }

        public double GetPressure()
        {
            return pressure;
        }

        // calculate pressure
        private void Calc()
        {
            // get pressure in pascals given user input
            // convert to metric version of ideal gas law
            double molesOfGas = mass / moleWeight;
            double degreeKelvin = temp + 273.15;

            pressure = (molesOfGas * 8.3145 * degreeKelvin) / volume;
        }
    }
}
